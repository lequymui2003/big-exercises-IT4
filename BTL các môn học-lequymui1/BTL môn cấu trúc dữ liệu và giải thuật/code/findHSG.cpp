#include<bits/stdc++.h>
using namespace std;

void findHSG(sv a){
	cout<<"DANH SACH SINH VIEN :\n";
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
	printf("| %-10s | %-20s | %-20s | %-20s | %-25s | %-25s \n", "MaSv", "Ho", "Dem","Ten", "Lop", "DTB");
	float DTB=8.0;
	while(a != NULL){
		if(DTB <= a->s.dtb){ 
			in(a->s);
		}
		a = a->next;
	}
	cout<<endl;
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
}
