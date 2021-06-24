#include <stdio.h>
//#define MaxSize 10
#define MaxSize 10
typedef struct{
    int data[MaxSize];
    int length;
}SqList;

void InitList(SqList &L) {
    for (int i = 0; i < MaxSize; i++)
        L.data[i] = 0;
    L.length = 0;
}

bool ListDelete(SqList L, int i, int& e) {
    if (i<1 || i>L.length)
        return false;
    e = L.data[i - 1];
    for (int j = i; j < L.length; j++)
        L.data[j - 1] = L.data[j];
    L.length--;
    return true;
}

int main() {
    SqList L;
    InitList(L);
    //...此处省略一些代码，插入几个元素
    int e = -1;
    if (ListDelete(L, 3, e))
        printf("已删除第3个元素，删除元素值为=%d\n", e);
    else
        printf("位序i不合法，删除失败\n");
    return 0;
}

