#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <locale.h>

struct Dugum{ // Bagli liste structi.

	int adet;
	char kelime[15];
	struct	Dugum *sonraki;
	struct  Dugum *onceki;
};

typedef struct Dugum Dugum;

void yazdir(Dugum * root){ // Bagli Listeyi ekrana yazdiran fonksiyon.
    int a=1; printf("\n");
    while( root != NULL){
        printf("%d. ",a);
        printf("%s", (root -> kelime) );

        printf(": %d",root->adet);
        root = root -> sonraki;
        printf("\n"); a++;
    }
}

Dugum *olustur() { // Yeni bir dugum olusturan fonksiyon.
    Dugum *newNode = (Dugum *)malloc(sizeof(Dugum));
    newNode->adet=0;
    newNode->sonraki = NULL;
   	newNode->onceki = NULL;
    return newNode;
}

void Dugumsil(Dugum *r,Dugum *gezer){ // iki dugum esitse birini silen fonksiyon.

	while(r!=gezer){

	    	if(strcmp(r->kelime,gezer->kelime)==0){// Esitlik kontrolu ve silme islemi.
	    		Dugum *silincekDugum;
	    		silincekDugum=gezer;
	    		gezer=gezer->onceki;
	    		gezer->sonraki=NULL;
	    		free(silincekDugum);
	    		break;
			}
			else
				r=r->sonraki;
		}
}

Dugum* arayaEkle(Dugum*r,Dugum*eklenen){ // Araya eleman ekleyen fonksiyon.
    Dugum* temp = r;
    if(eklenen->adet ==1){ // araya eklenen dugumun adedi 1 ise fonksiyona girmez.
        return r;
    }

    if(r==eklenen){ // Eklenen deger ilk deger ise islem yapilmaz.
        return r;
    }
    if(eklenen->adet >= r->adet){// Eklenen dugumun adedi 1. dugume esitse veya buyukse islem yapilmaz.
        return r;
    }
    while(eklenen->adet < r->adet && r->sonraki!=NULL){
        r = r->sonraki;
        if(r==eklenen && r->sonraki!=NULL){
            r = r->sonraki;
        }
    }

    if(r==eklenen){ // while'dan ciktiktan sonra eklenen, r ile esitse islem yapilmaz.
        return temp;
    }

    if(eklenen->sonraki == NULL && eklenen!=r){ // Eklenen deger en son deger ise.
    	eklenen->onceki->sonraki = eklenen->sonraki;
    	//eklenen->sonraki->onceki = eklenen->onceki;
    	eklenen->sonraki = r;
    	r->onceki->sonraki = eklenen;
    	eklenen->onceki = r->onceki;
    	r->onceki = eklenen;
    	return temp;
	}
    // Genel araya ekleme islemi.
    eklenen->onceki->sonraki = eklenen->sonraki;
    eklenen->sonraki->onceki = eklenen->onceki;
    eklenen->sonraki = r;
    r->onceki->sonraki = eklenen;
    eklenen->onceki = r->onceki;
    r->onceki = eklenen;

    return temp;
}

Dugum * basaEkle(Dugum *r,Dugum *eklenen){  // Eklenen * elemanini basa ekler.
            if(eklenen->adet >= r->adet && eklenen->adet!=1){
           // en son degeri basa ekler.

            eklenen->onceki->sonraki = eklenen->sonraki;
            //eklenen->sonraki->onceki = eklenen->onceki;
            eklenen->sonraki = r;
            r->onceki = eklenen;
            eklenen->onceki = NULL;
            return eklenen;

    }else{
        return r;
        }
    }

Dugum * sonaEkle(Dugum*iter){ // Listenin en sonuna dugum olusturan fonskiyon.
    iter->sonraki = (Dugum*) malloc(sizeof(Dugum));
    iter->sonraki->onceki=iter;
    iter=iter->sonraki;
    iter->adet=0;
    iter->sonraki=NULL;
    return iter;
}

struct Dugum* kok = NULL; // Ana dugum structini global olarak tanimlama islemi.

Dugum * sayEkle(Dugum * r){ //sona ekleme yapar

    Dugum* root = r; // 1. dugumu gosteren dugum.
	Dugum* iter=r; // iterator.

    while(iter->sonraki!=NULL){ // en son dugume gitme islemi.
        iter = iter->sonraki;
    }

  	char geciciKelime[20]; // sırayla dosyadan okunan kelimelerin kıyaslaması icin gecici string.
  	FILE *fp;

	if((fp=fopen("okunandosya.txt","r"))==NULL){
		printf("dosya bulunamadı.");
		return 0;
	}

	if(r->sonraki==NULL){ // 1. ile 2. dugumun kiyaslanmasi icin istisnai durum.

		while(!feof(fp)){

	    	fscanf(fp, "%s", &geciciKelime);

			if(strcmp(iter->kelime,geciciKelime)==0){
				iter->adet+=1;
			}
		}

		fclose(fp);
		iter=sonaEkle(iter); // en sona yeni bir dugum ekleme islemi.
		return iter;
	}
	else{
		//Eger daha once boyle bir kelime aranmıs ise tekrar arama ve dugum olusturmadan gonder
		while(r->sonraki!=iter){
			if(strcmp(iter->kelime,r->kelime)==0){
				return iter;
			}
			else{
				r=r->sonraki;
			}
		}

		//daha once boyle bir dugum oluşmamissa son dugum ile
		//bir onceki dugume bak eğer esit degil ise son dugumdeki kelime sayısnı bulan islem.
		if(strcmp(iter->kelime,r->kelime)!=0){

			while(!feof(fp)){

		    	fscanf(fp,"%s",&geciciKelime);//sirayla dosyadaki tum kelimerle bagli listeye eklenecek kelime kiyaslanir.
				if(strcmp(iter->kelime,geciciKelime)==0){
					iter->adet+=1; // secilen kelime dosya icerisinde ne kadar varsa adedini o kadar arttirir.
				}

			}
			fclose(fp);

                // kelimenin adet sayisi 1. siradaki kelimeden buyukse basa eklenir.
                kok = basaEkle(root,iter); // Basa ekleme fonksiyonu.

                // kelimenin adet sayisi 1'den farkliysa adet sirasine gore araya eklenir.
                arayaEkle(root,iter); // Araya ekleme fonksiyonu.

            while(iter->sonraki!=NULL){
                iter = iter->sonraki;
            }
            iter = sonaEkle(iter); // en sona yeni bir dugum ekleme islemi.
			return iter;

		}
		else{
			return iter;
		}
	}
}

int main(int argc, char *argv[]) {

	setlocale(LC_ALL, "Turkish");

    struct Dugum* gezer = NULL; // iterator.

	FILE *fp;

	if((fp=fopen("okunandosya.txt","r"))==NULL){
		printf("dosya bulunamadı.");
		return 0;
	}

		kok = olustur(); // ilk dugumu olusturma islemi.
	    fscanf(fp,"%s",&kok->kelime);
	    gezer = kok; // iterator atama islemi.

		while (!feof(fp)){

				// Listeye otomatik kelime ekleme metodu.
				gezer = sayEkle(kok);// Tum ekleme metodlari bu fonksiyon icerisinde kullanilmistir.
                                    //                              basaEkle(), arayaEkle() vesayre.
			    fscanf(fp,"%s",&gezer->kelime); // dosyadan kelime okuma islemi.

				//yazdir(kok); puts("\n---------------\n");
	    }

	gezer->adet+=1;
	fclose(fp);
	Dugumsil(kok,gezer); // son okunan kelime daha zaten bagli listede varsa bu islemle silinir.

	yazdir(kok); // bagli listeyi ekrana yazdirir.

	return 0;
}



