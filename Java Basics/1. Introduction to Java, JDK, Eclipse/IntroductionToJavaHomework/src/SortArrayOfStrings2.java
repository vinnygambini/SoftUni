	

    import java.util.Scanner;
    import java.util.Arrays;
    public class SortArrayOfStrings2 {
     
            public static void main(String[] args) {
            	System.out.println("Number of words? ");
                    Scanner input = new Scanner(System.in);
                    int n = input.nextInt();
                System.out.println("Enter the word and hit Enter ");
                    String[] allWords = new String[n];
                    for(int i=0;i<n;i++)
                    {
                            allWords[i] = input.next();
                    }
                    Arrays.sort(allWords);
                    for(int i=0;i<n;i++)
                    {
                    	System.out.println("The right order is ");
                            System.out.println(allWords[i]);
                    }
            }
    }

