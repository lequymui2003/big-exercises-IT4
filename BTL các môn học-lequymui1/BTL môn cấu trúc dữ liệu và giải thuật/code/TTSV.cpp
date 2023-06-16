#include<bits/stdc++.h>
using namespace std;


sv makeNode(){
	SinhVien s;
	cout<<"Nhap thong tin sinh vien:\n";
	printf("Nhap ma : ");
	scanf("%d",&s.ma);
	if(s.ma <= 0) return 0;
	fflush(stdin);
	printf("Nhap ho : ");
	gets(s.ho);
	printf("Nhap dem : ");
	gets(s.dem);
	printf("Nhap ten : ");
	gets(s.ten);
	printf("Nhap lop: ");
	gets(s.tenlop);
	printf("Nhap diem trung binh: ");
    scanf("%f",&s.dtb);
	sv tmp = new SV();
	tmp->s = s;
	tmp->next = NULL;
	return tmp;
}
bool empty(sv a){
	return a == NULL;
}

int Size(sv a){
	int cnt = 0;
	while(a != NULL){
		++cnt;
		a = a->next;
	}
	return cnt;
}
