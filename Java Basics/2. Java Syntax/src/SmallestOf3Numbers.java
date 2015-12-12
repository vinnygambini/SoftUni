import java.util.Scanner;


public class SmallestOf3Numbers {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Scanner input = new Scanner(System.in);
		System.out.print("Enter x= ");
		double x = input.nextDouble();
		System.out.println("Enter y= ");
		double y = input.nextDouble();
		System.out.println("Enter z= ");
		double z = input.nextDouble();
		
		if ((x < y) && (x < z)) {
			System.out.println("The smallest number is = " + x);
		
		} else if ((y < x) && (y < z)) {
			System.out.println("The smallest number is = " + y);

		}
		else {
			System.out.println("The smallest number is = " + z);
		}
		
	}

}
