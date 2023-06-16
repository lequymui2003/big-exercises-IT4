#include<bits/stdc++.h>
using namespace std;

void in(SinhVien s){
	printf("| %-10d ",s.ma);
	printf("| %-20s ",s.ho);
	printf("| %-20s ",s.dem);
	printf("| %-20s ",s.ten);
	printf("| %-25s ",s.tenlop);
	printf("| %-25.2f\n",s.dtb);	
}

void inds(sv a){
	cout<<"DANH SACH SINH VIEN :\n";
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
	printf("| %-10s | %-20s | %-20s | %-20s | %-25s | %-25s \n", "MaSv", "Ho", "Dem","Ten", "Lop", "DTB");
	while(a != NULL){
		in(a->s);
		a = a->next;
	}
	cout<<endl;
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
}
