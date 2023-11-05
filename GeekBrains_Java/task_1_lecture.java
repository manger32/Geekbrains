import java.io.BufferedReader;
import java.io.FileReader;
import java.util.Random;
import java.util.regex.Pattern;
public class task_1_lecture {
    /*
        1. Задана натуральная степень k. Сформировать случайным
        образом список коэффициентов (значения от 0 до 100)
        многочлена многочлен степени k.
        *Пример: k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0
        2. Даны два файла, в каждом из которых находится запись
        многочлена. Сформировать файл содержащий сумму
        многочленов.
    */
    public static void main(String[] args) throws Exception{
        int k = Integer.parseInt(args[0]);
        int[] array_coefficients = new int[k];
        for (int i = 0; i < array_coefficients.length; ++i)
        {
            Random rnd = new Random();
            int number = rnd.nextInt(100);
            array_coefficients[i] = number;
        }
        BufferedReader br1 = new BufferedReader(new FileReader("polynomial1.txt"));
        BufferedReader br2 = new BufferedReader(new FileReader("polynomial2.txt"));
        String str1 = br1.readLine();
        String str2 = br2.readLine();
        int[] array_coefficients_1 = ConvertToArray(str1);
        int[] array_coefficients_2 = ConvertToArray(str2);
        System.out.println(str1 + '\n' + str2);
        br1.close();
        br2.close();
    }
    static int[] ConvertToArray(String s)
    {
        String[] members = s.split("\\+");
        int len = members.length;
        int[] coefficients = new int[len];
        for (int i = 0; i < len; ++i)
            coefficients[i] = 0;
        for (int i = 0; i < len; ++i)
        {
            String[] qres = members[i].split("\\*");
            if (qres[0].charAt(0) == 'x')
            {
                System.out.println(1);
                coefficients[(int) qres[0].charAt(2) - '0'] = 1;
            }
            else
            {
                System.out.println(qres[1]);
                coefficients[(int) qres[1].charAt(2) - '0'] = Integer.parseInt(qres[0]);
            }
        }
        return new int[1];
    }
}
