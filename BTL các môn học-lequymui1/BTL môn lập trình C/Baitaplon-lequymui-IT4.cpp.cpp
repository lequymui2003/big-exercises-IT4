#include<stdio.h>
#include <conio.h>
struct date{
	int ngay;
	int thang;
	int nam;
};
struct sinhvien{
	int id;
	char hodem[20];
	char ten[10];
    char gioiTinh[5];
    date ngaySinh;
    float diemtoancaocap ;
    float diemtriethoc;
    float diemlaptrinhC;
    float diemTrungBinh;
    char maLop[30];
    char xeploai[10];
};
typedef struct sinhvien SV;

void nhapSinhVien(SV &sv);
void inSinhVien(SV sv);
void tinhDiemTrungBinh(SV &sv);
void xepLoai(SV ds);
void xeploaiN(SV ds[], int n);
void nhapdanhsachsinhvien(SV ds[],int &n);
void xuatdanhsachsinhvien(SV ds[],int n);
void sapxepdanhsachsinhvientheoDTB(SV ds[], int n);
void xuatFile(SV ds[], int n, char fileName[]);

void nhapsinhvien(SV &sv){
	printf("\nID:");scanf("%d",&sv.id);
	if(sv.id<=0){
		return;
	}
	printf("\n Ho dem:");fflush(stdin);gets(sv.hodem);
	printf("\nTen sinh vien:");fflush(stdin);gets(sv.ten);
	printf("\nGioi tinh sinh vien:");fflush(stdin);gets(sv.gioiTinh);
	printf("\nNgay sinh :"),scanf("%d%d%d",&sv.ngaySinh.ngay,&sv.ngaySinh.thang,&sv.ngaySinh.nam);
	printf("\nDiem toan cao cap:"),scanf("%f",&sv.diemtoancaocap);
	printf("\nDiem triet hoc:"),scanf("%f",&sv.diemtriethoc);
	printf("\nDiem lap trinh C:"),scanf("%f",&sv.diemlaptrinhC);
	printf("\nTen lop:");fflush(stdin);gets(sv.maLop);
	tinhDiemTrungBinh(sv);
	printf("\n");
}
void insinhvien(SV sv){
	printf("\nID:%d\t",sv.id);
	printf("\nHo dem: %s", sv.hodem);
	printf("\nTen sinh vien:%s",sv.ten);
	printf("\nGioi tinh:%s",sv.gioiTinh);
	printf("\nNgay sinh:%d/%d/%d",sv.ngaySinh.ngay,sv.ngaySinh.thang,sv.ngaySinh.nam);
	printf("\nDiem toan cao cap:%.2f",sv.diemtoancaocap);
	printf("\nDiem triet hoc:%.2f",sv.diemtriethoc);
	printf("\nDiem lap trinh C:%.2f",sv.diemlaptrinhC);
	printf("\nDiemtrungbinh:%.2f",sv.diemTrungBinh);
	printf("\nMa lop:%s",sv.maLop);
}

void tinhDiemTrungBinh(SV &sv){
    sv.diemTrungBinh = (sv.diemtoancaocap + sv.diemtriethoc + sv.diemlaptrinhC)/3;    
}


void xeploai(SV sv){
    if(sv.diemTrungBinh >= 8) printf("Gioi");
    else if(sv.diemTrungBinh >= 6.5) printf("Kha");
    else if(sv.diemTrungBinh >= 5) printf("Trung binh");
    else printf("Yeu");
}

void xeploaiN(SV ds[], int n){
    printf("\n____________________________________\n");
    for(int i = 0;i < n;++i){
        printf("\nXep loai cua SV thu %d la: ", i+1);
        xeploai(ds[i]);
    }
    printf("\n____________________________________\n");
}

void nhapdanhsachsinhvien(SV ds[],int &n){
	printf("\n____________________________________\n");
	for(int i=0;i<n;i++){
		printf("\n nhap vao sinh vien thu %d:",i+1);
		nhapsinhvien(ds[i]);
	}
	printf("\n____________________________________\n");
}
void xuatdanhsachsinhvien(SV ds[],int n){
	printf("\n____________________________________\n");
	for(int i=0;i<n;i++){
	printf("\nThong tin SV thu %d:", i+1);
	insinhvien(ds[i]);
   }
   printf("\n____________________________________\n");
}
void sapxepdanhsachsinhvientheoDTB(SV ds[], int n){
	for(int i=0;i<n-1;i++){
		for(int j=i+1;j<n;j++){
			if(ds[i].diemTrungBinh<ds[j].diemTrungBinh){
				SV temp;
				temp=ds[i];
				ds[i]=ds[j];
				ds[j]=temp;
			}
			
		}
	}
	
}

void xuatFile(SV a[], int n, char fileName[]){
    FILE * fp;
    fp = fopen (fileName,"w");
    fprintf(fp, "%10s%15s%10s%10s%10s%10s\n", "Ho Ten","Gioi Tinh", "DT ", "DTH", "DLTC", "DTB");
    for(int i = 0;i < n;i++){
        fprintf(fp, "%14s%8s%13.1f%11.1f%11.1f%11.1f\n", a[i].ten, a[i].gioiTinh, a[i].diemtoancaocap, a[i].diemtriethoc, a[i].diemlaptrinhC, a[i].diemTrungBinh);
    }
    fclose (fp);
}

int main(){
 int chon,n;
    char fileName[] = "TTSV.txt";
    bool Nhap = false;
    do{
        printf("\nNhap so luong SV: "); scanf("%d", &n);
    }while(n <= 0);
    SV ds[n];
    while(true){
        
        printf("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");
        printf("+-      CHUONG TRINH QUAN LY SINH VIEN       -+\n");
        printf("+-    1. Nhap du lieu                        -+\n");
        printf("+-    2. In danh sach sinh vien              -+\n");
        printf("+-    3. Sap xep sinh vien theo DTB          -+\n");
        printf("+-    4. Xep loai sinh vien                  -+\n");
        printf("+-    5. Xuat DS sinh vien                   -+\n");
        printf("+-    0. Thoat                               -+\n");
        printf("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");
        printf("++         Nhap lua chon cua ban            ++\n");
        scanf("%d",&chon);
        switch(chon){
            case 1:
                printf("\nBan da chon nhap DS sinh vien");
                nhapdanhsachsinhvien(ds, n);
                printf("\nBan da nhap thanh cong!");
                Nhap = true;
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
            case 2:
                if(Nhap){
                    printf("\nBan da chon xuat DS sinh vien");
                    xuatdanhsachsinhvien(ds, n);
                }else{
                    printf("\nNhap DS SV truoc");
                }
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
            case 3:
                if(Nhap){
                    printf("\nBan da chon sap xep SV theo STB");
                    sapxepdanhsachsinhvientheoDTB(ds, n);
                    xuatdanhsachsinhvien(ds, n);
                }else{
                    printf("\nNhap DS SV truoc!!!!");
                }
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
            case 4:
                if(Nhap){
                    printf("\nBan da chon thoat xep loai SV");
                    xeploaiN(ds, n);
                }else{
                    printf("\nNhap DS SV truoc!!!!");
                }
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
            case 5:
                if(Nhap){
                    printf("\nBan da chon xuat DS SV");
                    xuatFile(ds, n, fileName);
                }else{
                    printf("\nNhap DS SV truoc");
                }
                printf("\nXuat DSSV thanh cong vao file %", fileName);
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
            case 0:
                printf("\nBan da chon thoat chuong trinh");
                getch();
                return 0;
            default:
                printf("\nKhong co chuc nang nay");
                printf("\nBam phim bat ky de tiep tuc");
                getch();
                break;
        }	
    }
}
 


