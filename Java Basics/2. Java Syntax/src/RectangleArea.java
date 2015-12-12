import java.util.Scanner;


public class RectangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Scanner input = new Scanner(System.in);
		System.out.println("Enter side a= ");
		int a = input.nextInt();
		System.out.println("Enter side b= ");
		int b = input.nextInt();
		int area = a * b;
		System.out.println("The Area of the Rectangle is = " + area);
		
	}
}