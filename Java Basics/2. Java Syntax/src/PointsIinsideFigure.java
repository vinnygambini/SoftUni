import java.util.Scanner;


public class PointsIinsideFigure {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
			
		Scanner input = new Scanner(System.in);
		System.out.print("Enter x= ");
		double x = input.nextDouble();
		System.out.println("Enter y= ");
		double y = input.nextDouble();
		
		if ((x>=12.5 && x<=22.5 && y>=6 && y<=8.5)
                ||(x>=12.5 && x<=17.5 && y>=8.5 && y<=13.5)
                ||(x>=20 && x<=22.5 && y>=8.5 && y<=13.5)){
                System.out.println("Inside");
        }else {
                System.out.println("Outside");
        }
	}

}
