/**
 * program hello_world 
 * to test java interpreter and compiler on VS Code
 */
public class hello_world {
    public static void main(String[] args) {
        String s = "Hello world, it is Jermaine ";
        String h = null;
        System.out.println(s + args[0]);
        System.out.println(h);
        int num = 19;
        float f = 123.45f;
        double d = 123.456D;
        char fig = '{';
        char fig1 = 124;
        char fig2 = 125;
        String numbersCombined = fig + String.valueOf(num) + fig1 + String.valueOf(f) + fig1 + String.valueOf(d) + fig2;
        System.out.println(numbersCombined);
        boolean B = true && false || true ^ false;
        System.out.println(B);
        var i = 65_536;
        System.out.println(Integer.MAX_VALUE);
        System.out.println(Integer.MIN_VALUE);
        System.out.println(Math.sqrt(i));
    }
}