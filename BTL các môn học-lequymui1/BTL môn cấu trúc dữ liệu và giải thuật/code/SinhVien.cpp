#include<bits/stdc++.h>
using namespace std;
struct SinhVien{
	int ma;
	char ho[40];
	char dem[40];
	char ten[40];	
	char tenlop[30];		
	float dtb;
};

struct SV{
	SinhVien s;
	SV *next;
};

typedef struct SV* sv;
