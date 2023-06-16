#include<bits/stdc++.h>
#include<stdio.h>
#include<conio.h>
#include"intro.c"
#include"SinhVien.cpp"
#include"TTSV.cpp"
#include"ThêmSV.cpp"
#include"inSV.cpp"
#include"findHSG.cpp"
#include"findSv.cpp"
#include"sapxep.cpp"
#include"LKsv.cpp"
using namespace std;




int main(){
	sv head = NULL;
	int luaChon;
	intro();
    printf(" Chon mot phim bat ky de bat dau chuong trinh nao\n\n");
    getch();
    int i;
    
	while(true){
 	    printf("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
        printf("+-      CHUONG TRINH QUAN LY DANH SACH SINH VIEN       -+\n");
        printf("+-   1. Them sinh vien vao DS                          -+\n");
        printf("+-   2. Duyet danh sach lien ket                       -+\n");
        printf("+-   3. Sap xep sinh vien giam dan theo DTB            -+\n");
        printf("+-   4. Tim sinh vien loai gioi(DTB>=8)                -+\n");
        printf("+-   5. Tim sinh vien theo ten lop                     -+\n");
        printf("+-   6. Liet ke sv co DTB tu a den b nhap tu ban phim  -+\n");
        printf("+-   0. Thoat                                          -+\n");
        printf("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n");
        printf("++             Nhap lua chon cua ban                   ++\n");
        
 	scanf("%d", &luaChon);
 	struct SinhVien sv;
 	int i;
 	switch(luaChon){
 		case 0:
 			break;
        case 1:
        	
        	int pos; cout<<"Nhap vi tri can chen:"; cin >> pos;
			insertMiddle(head, pos);
        	break;
        case 2:
        	inds(head);
        	break;
        case 3:
        	sapxep(head);
        	break;
        case 4:
        	findHSG(head);
        	break;
        case 5:
        	char s[50];
			printf("Nhap ten lop can thong ke: ");
			fflush(stdin);
			gets(s);
        	findSv(head, s);
        	break;
        case 6:
        	Lmao(head);
        	break;
        default:
        	printf("Sai chuc nang vui long ban chon dung chuc nang\n");
        	break;
        	
	 }
 	
 }
 
return 0;
}
				
				
				
				
				
				
				
				
				
				
				
				
				
				
	











