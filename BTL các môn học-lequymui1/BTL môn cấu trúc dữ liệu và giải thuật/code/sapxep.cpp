#include<bits/stdc++.h>
using namespace std;

void sapxep(sv &a){
	for(sv p = a; p->next != NULL; p= p->next){
		sv min = p;
		for(sv q = p->next; q != NULL; q = q->next){
			if(q->s.dtb > min->s.dtb){
				min= q;
			}
		}
		SinhVien tmp = min->s;
		min->s = p->s;
		p->s = tmp;
	}
}
