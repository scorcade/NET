
#include <stdio.h>
#define MaxSize 10
typedef struct{
    int date[MaxSize];
    int length;
}SqList;
bool ListInsert(SqList &L, int i, int e){
    if (i<1||i>L.length+1)
        return false;
    if (L.length>=MaxSize)
        return false;
    for(int j=L.length; j>=i; j--)
        L.data[j]=L.data[j-1];
    L.data[i-1]=e;
    L.legth++;
    return true;
}
int main()
{
    Sqlist L;
    InitList(L);
    //...此处省略一些代码，插入几个元素
    ListInsert(L, 3, 3);
    return 0;
}