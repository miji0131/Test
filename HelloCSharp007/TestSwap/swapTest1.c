#include<stdio.h>


// ������ = �ּҸ� �����ϴ� ����
void swap(int* x, int* y)
{
	//x, y ���� �ٲ�
	int temp = *x;
	*x = *y;
	*y = temp;
}
int main()
{
	int a = 3;
	int b = 5;
	//int temp = a;	//���� temp�� �ٸ�
	//a = b;
	//b = temp;
	printf("%d %d\n", a, b);
	swap(&a, &b);	//���� ������ ������ ����Ŵ
	printf("%d %d\n", a, b);
	return 0;
}