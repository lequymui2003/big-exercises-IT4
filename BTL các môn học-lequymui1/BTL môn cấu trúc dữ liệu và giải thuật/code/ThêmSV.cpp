#include<bits/stdc++.h>
using namespace std;

void insertFirst(sv &a){
	sv tmp = makeNode();
	if(a == NULL){
		a = tmp;
	}
	else{
		tmp->next = a;
		a = tmp;
	}
}

void insertLast(sv &a){
	sv tmp = makeNode();
	if(a == NULL){
		a = tmp;
	}
	else{
		sv p = a;
		while(p->next != NULL){
			p = p->next;
		}
		p->next = tmp;
	}
}


void insertMiddle(sv &a, int pos){
	int n = Size(a);
	if(pos <= 0 || pos > n+1){
		cout<<"Vi tri chen khong hop le!\n"; return;
	}
	if(pos == 1){
		insertFirst(a); return;
	}
	else if(pos == n + 1){
	insertLast(a); return;
	}
	sv p = a;
	for(int i = 1; i < pos - 1; i++){
		p = p->next;
	}
	sv tmp = makeNode();
	tmp->next = p->next;
	p->next = tmp;
}
