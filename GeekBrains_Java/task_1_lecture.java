import java.io.BufferedReader;
import java.io.FileReader;
import java.util.Random;
import java.util.regex.Pattern;
public class task_1_lecture {
    /*
        1. Задана натуральная степень k. Сформировать случайным
        образом список коэффициентов (значения от 0 до 100)
        многочлена многочлен степени k.
        *Пример: k=2 => 2*x^2 + 4*x + 5 или x^2 + 5 или 10*x^2
        2. Даны два файла, в каждом из которых находится запись
        многочлена. Сформировать файл содержащий сумму
        многочленов.
    */
    public static void main(String[] args) throws Exception{
        GetArrayCoefficients(Integer.parseInt(args[0]));
        BufferedReader br1 = new BufferedReader(new FileReader("polynomial1.txt"));
        BufferedReader br2 = new BufferedReader(new FileReader("polynomial2.txt"));
        String str1 = br1.readLine();
        String str2 = br2.readLine();
        int[] array_coefficients_1 = ConvertToArray(str1);
        int[] array_coefficients_2 = ConvertToArray(str2);
        /**for (int i = 0; i < array_coefficients_1.length; i++) {
            System.out.println(array_coefficients_1[i]);
        }
        System.out.println("__");
        for (int i = 0; i < array_coefficients_2.length; i++) {
            System.out.println(array_coefficients_2[i]);
        }**/
        int[] resulting_array_coefficients = new int[Integer.max(array_coefficients_1.length,array_coefficients_2.length)];
        int j = 0;
        for (j = 0; j < resulting_array_coefficients.length; ++j)
            resulting_array_coefficients[j] = 0;
        for (j = 0; j < Integer.min(array_coefficients_1.length,array_coefficients_2.length); ++j)
        {
            resulting_array_coefficients[j] = array_coefficients_1[j] + array_coefficients_2[j];
        }
        if (array_coefficients_1.length > array_coefficients_2.length)
            for (;j < Integer.max(array_coefficients_1.length,array_coefficients_2.length); ++j)
                resulting_array_coefficients[j] = array_coefficients_1[j];
        else
            for (;j < Integer.max(array_coefficients_1.length,array_coefficients_2.length); ++j)
                resulting_array_coefficients[j] = array_coefficients_2[j];
        for (int i = 0; i < resulting_array_coefficients.length;++i)
            System.out.print(resulting_array_coefficients[i] + " ");
        br1.close();
        br2.close();
    }

    /*Function that converts String polynomial to coefficients array */
    static int[] ConvertToArray(String s)
    {
        String[] members = s.split("\\+");
        int[] coefficients = new int[Integer.parseInt(members[0].substring(members[0].indexOf('x') + 2, members[0].length()))+1];
        for (int i = 0; i < coefficients.length; ++i)
            coefficients[i] = 0;
        for (int i = 0; i < members.length; ++i)
        {
            String[] qres = members[i].split("\\*");
            //System.out.println(members[i]);
            if (qres[0].charAt(0) == 'x')
                coefficients[(int) qres[0].charAt(2) - '0'] = 1;
            else if (qres.length == 1)
                coefficients[0] = Integer.parseInt(qres[0]);
            else
                coefficients[(int) qres[1].charAt(2) - '0'] = Integer.parseInt(qres[0]);
        }
        return coefficients;
    }

    /*Function that generates a random array of coefficients and outputs them to sysout*/
    static void GetArrayCoefficients(int k)
    {
        int[] array_coefficients = new int[k];
        for (int i = 0; i < array_coefficients.length-1; ++i)
        {
            Random rnd = new Random();
            int number = rnd.nextInt(10);
            array_coefficients[i] = number;
            int which = array_coefficients.length-1-i;
            if (i != array_coefficients.length-2)
                    System.out.print(array_coefficients[i] + "*x^" + which + " + ");
            else
            {
                rnd = new Random();
                number = rnd.nextInt(10);
                array_coefficients[array_coefficients.length - 1] = number;
                System.out.print(array_coefficients[i] + "*x + " + array_coefficients[array_coefficients.length - 1]);
            }
        }
        System.out.println();
    }   
}
