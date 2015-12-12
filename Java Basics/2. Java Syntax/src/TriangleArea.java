import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input = new Scanner(System.in);
		System.out.println("Enter side Ax= ");
		int Ax = input.nextInt();
		System.out.println("Enter side Ay= ");
		int Ay = input.nextInt();
		
		System.out.println("Enter side Bx= ");
		int Bx = input.nextInt();
		System.out.println("Enter side By= ");
		int By = input.nextInt();
		
		System.out.println("Enter side Cx= ");
		int Cx = input.nextInt();
		System.out.println("Enter side Cy= ");
		int Cy = input.nextInt();
		
		if ((Ax == Ay) && (Bx == By) && (Cx == Cy)){
			System.out.println("The points are out of  the triangle...result = 0");
		}else {
			int Area = (int)Math.abs((Ax*(By - Cy) + Bx*(Cy - Ay) + Cx*(Ay - By))/2);
			
			System.out.println("The Area is = " + Area);
		}
		
		
		
	}

}
