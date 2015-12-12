import java.util.Scanner;


public class DecimalToHexadecimal {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
        System.out.println("Enter an Integer...");
        int number = input.nextInt();
        System.out.println(Integer.toHexString(number).toUpperCase());
        
	}

}
