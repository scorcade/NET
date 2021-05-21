#define _CRT_SECUER_NO_WARNINGS 1

#include <stdio.h>
#include <limits.h>

int main() {
	int arr[] = { 1,2,3,4,5,1,2,3,4,5,6,6,7,8,7 };
	int i = 0;
	int ret = 0;
	int sz = sizeof(arr) / sizeof(arr[0]);

	for (i = 0; i < sz; i++)
	{
		ret = ret^arr[i];
	}
	printf("this's %d\n",ret);

	//for ( i = 0; i < sz; i++)-------------------
	//{
	//	int count = 0;

	//	for (int j = 0; j < sz; j++)
	//	{
	//		if (arr[i] == arr[j])
	//		{
	//				count++;
	//		}
	//	}
	//	if (count == 1)
	//	{
	//		printf("this is %d\n",arr[i]);
	//		break;
	//	}
	//}


	return 0;
}

