#include<iostream>
using namespace std;
void swap(int& x, int& y)
{
	int temp = x;
	x = y;
	y = temp;
}
int main()
{
	int a = 3;
	int b = 5;

	//������ : C++���� &���̰� C#���� ref�� Ű���带 ����
	//������ : ������ ����� ���� �����ϰ�, �� ������ �ִ� ��ġ�� ���� ������ ����
	int& refa = a;
	int& refb = b;
	cout << refa << refb << endl;


	swap(a, b);
	cout << a << b << endl;
	swap(refa, refb);
	cout << a << b << endl;
	return 0;
}