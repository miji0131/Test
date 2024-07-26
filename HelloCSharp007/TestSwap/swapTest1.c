#include<stdio.h>


// 포인터 = 주소를 저장하는 변수
void swap(int* x, int* y)
{
	//x, y 값을 바꿈
	int temp = *x;
	*x = *y;
	*y = temp;
}
int main()
{
	int a = 3;
	int b = 5;
	//int temp = a;	//위의 temp랑 다름
	//a = b;
	//b = temp;
	printf("%d %d\n", a, b);
	swap(&a, &b);	//위의 포인터 변수를 가리킴
	printf("%d %d\n", a, b);
	return 0;
}