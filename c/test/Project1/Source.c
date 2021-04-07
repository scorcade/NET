#include<stdio.h>


//void bublle_sort(int arr[]);
void bubble_sort(int arr[], int sz)
{
	//int sz = sizeof(*arr) / sizeof(arr[0]);
	for (int i = 0; i < sz - 1; i++)
	{
		int flag = 1;

		for (int j = 0; j < sz - i - 1; j++)
		{
			if (arr[j] > arr[j+1])
			{
				arr[j] = arr[j+1]+ arr[j];
				arr[j+1] = arr[j]- arr[j+1];
				arr[j] = arr[j]-arr[j+1];

			}
		}
		if (flag == 1)
		{
			break;
		}

	}
}


 int main() {
	//char arr1[] = { 'a','b','c','d','e','f' };
	int arr[] = { 9,8,7,6,5,4,3,2,1,0 };
	int sz = sizeof(arr)/sizeof(arr[0]);

	bubble_sort(arr,sz);

	for (int i = 0; i < sz; i++)
	{
		printf("%d ",arr[i]);
	}

	


	//int arr1[3][4] = { {1,2,3,4}, {5,6,7,8} };-----------------

	//for (int  i = 0; i < 3; i++)
	//{
	//	for (int j = 0; j < 4; j++)
	//	{
	//		printf("%d ",arr1[i][j]);
	//	}
	//	printf("%\n");

	//}





	//int sz = sizeof(arr1) / sizeof(arr1[0]);---------------------------
	//
	//for ( int i = 0; i < sz; i++)
	//{
	//	printf("&arr1[%d]=%p\n", i, &arr1[i]);
	//}



	//char arr[] = "abcdef";-----------------------
	//printf("%d\n", sizeof(arr));
	//	printf("%d\n", strlen(arr));
	//		printf("%d\n", sizeof(arr1));
	//			printf("%d\n", strlen(arr1));

	//int xxx[] = {1,2,3,4,5,6};-------------
	//typedef unsigned int u_int;-------------------
	//u_int xxx = 10;

	return 0;
}

 
 