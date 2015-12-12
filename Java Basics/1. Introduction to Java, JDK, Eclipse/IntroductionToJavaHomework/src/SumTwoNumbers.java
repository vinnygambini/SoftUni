import java.util.*;
public class SumTwoNumbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Enter an integer a =  ");
		Scanner input = new Scanner(System.in);
		int a =  input.nextInt();
		
		System.out.println("Enter an integer b =  ");
		Scanner input2 = new Scanner(System.in);
		int b =  input2.nextInt();
		
		int result = a + b;
		System.out.println("The result a + b is " + result);
	}

}
