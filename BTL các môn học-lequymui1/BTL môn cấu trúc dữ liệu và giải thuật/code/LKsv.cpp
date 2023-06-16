#include<bits/stdc++.h>
using namespace std;

void Lmao(sv &m){
	int a;
	int b;
	cout << "Diem A :";
	cin >> a;
	cout << "Nhap diem B bat dau <= 10: ";
	cin >> b;
	printf("+----------------------------------------------------------------------------------------------------------------------+\n");
	printf("| %-10s | %-20s | %-20s | %-20s | %-25s | %-25s \n", "MaSv", "Ho", "Dem","Ten", "Lop", "DTB");
	for(sv p = m; p != NULL; p = p->next){	
		if(p->s.dtb >= a && p->s.dtb <= b){
			printf("| %-10d ",p->s.ma);
			printf("| %-20s ",p->s.ho);
			printf("| %-20s ",p->s.dem);
			printf("| %-20s ",p->s.ten);
			printf("| %-25s ",p->s.tenlop);
			printf("| %-25.2f\n",p->s.dtb);
		}
	}printf("+----------------------------------------------------------------------------------------------------------------------+\n");
}
