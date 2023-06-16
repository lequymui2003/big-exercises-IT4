#include<bits/stdc++.h>
using namespace std;

void findSv(sv a, char s[]){
	cout<<"DANH SACH SINH VIEN :\n";
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
	printf("| %-10s | %-20s | %-20s | %-20s | %-25s | %-25s \n", "MaSv", "Ho", "Dem","Ten", "Lop", "DTB");
	int check = 0;
	while(a != NULL){
	if(strcmp(a->s.tenlop,s) == 0) {
			check  = 1;
			in(a->s);
		}
		a = a->next;
	}
	cout<<endl;
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
}

