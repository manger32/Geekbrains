import java.util.Scanner;

public class arrays {
    public static void main(String[] args) {
        int[] arr = new int[Integer.parseInt(args[0])];
        int brr[]; // так тоже можно завести массив
        int i = 0;
        Scanner myInput = new Scanner( System.in );
        while (i < arr.length)
            if (myInput.hasNextInt())
                arr[i++] = myInput.nextInt();
        myInput.close();
        i = 0;
        while (i < arr.length)
            System.out.println(arr[i++]);
        // Multi-dimensional arrays
        int[] mehrdimensional[] = new int[Integer.parseInt(args[1])][Integer.parseInt(args[2])];
        for (int[] line : mehrdimensional)
        {
            for (int item : line)
            {
                System.out.printf("%d ", item);
            }
            System.out.println();
        }
        System.out.println();
        // Array of Arrays
        int[][] arrayOfArrays = new int[Integer.parseInt(args[1])][Integer.parseInt(args[2])];
        for (i = 0; i < arrayOfArrays.length; ++i)
        {
            for (int j = 0; j < arrayOfArrays[i].length; ++j)
            {
                System.out.printf("%d ", arrayOfArrays[i][j]);
            }
            System.out.println();
        }
        // Invariance of types - covariance and contravariance in type conversion of arrays
        int[] a = new int[10];
        //double[] d = a; 
        // fori, foreach
        int [] array = new int[] {1,2,3,4,5,6,7,8,9,100};
        for (int index = 0; index < array.length; index++) {
            int to_sqr = array[index];
            int sqr = to_sqr*to_sqr;
            array[index] = sqr;
        }
        for (int item : array)
        {
            System.out.println(item);
        }
    }
}
