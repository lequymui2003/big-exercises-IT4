#include <iostream>
#include <stdio.h>
#include <conio.h>

#define max 100
#define FileIn "F:\\G.txt"

using namespace std;
int chuaXet[max];

// A: ma tran ke cua G, n: so dinh
int A[max][max],n;

// doc file chua do thi G luu vao ma tran A


void Doc_File(int A[max][max], int &n) {
 FILE *f = fopen(FileIn,"rb");
 fscanf(f,"%d",&n);
 cout<<"\n So dinh: "<<n<<"\n Ma tran ke: "<<endl;
 for(int i =0;i<n;i++) {
   for(int j =0;j<n;j++) {
     fscanf(f,"%d",&A[i][j]);
  cout<<A[i][j]<<" ";
}
cout<<endl;
}
fclose(f);
}

// Khoi tao chua xet
void KhoiTao_ChuaXet(){
  for (int i=0;i<max;i++)
   chuaXet[i]=1;
 }

// thuat toan DFS
void DFS(int u){
// xet dinh u
 chuaXet[u]=0;
 cout<<u<<"->";
 for(int v=0;v<n;v++)
   if(chuaXet[v]==1&&A[u][v]==1)
   {
     DFS(v);
    }
 }


// thuat toan BFS

void BFS(int u){
  int queue[max], dau=0,cuoi=0;
  for(int i=0;i<max;i++) queue[i]=0;
    queue[cuoi]=u;
    chuaXet[u]=0;
    cout<<u<<"->";
 
while(dau>=cuoi)
 {
    int p=queue[cuoi];
    cuoi++;
   for(int v=0;v<n;v++)
     if(chuaXet[v]==1&&A[p][v]==1)
      { 
        dau++;
        queue[dau]=v;
        chuaXet[v] =0;
        cout<<v<<"->";
      }
   }
}

// Kiem tra chuaXet
int KT_ChuaXet(){
  for (int i=0;i<n;i++)
     if (chuaXet[i]==1) return i;
return -1;
}


// tim bac cac dinh
int Deg(int i){
   int deg=0;
   for(int j=0;j<n;j++)
   {
      deg +=A[i][j];
    }
   return deg;
 }




// ham chinh

int main() {
 // doc ma tran
 Doc_File(A,n);
 // Duyet do thi DFS
 KhoiTao_ChuaXet();
 cout<<"\n Duyet do thi DFS: ";
 DFS(0);
 // Duyet do thi BFS
 KhoiTao_ChuaXet();
 cout<<"\n Duyet do thi BFS: ";
 BFS(0);

return 0;
}

