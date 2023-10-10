/**
 * program hello_world 
 * to test java interpreter and compiler on VS Code
 */
public class hello_world_primitives {
    public static void main(String[] args) {
        String s = "Hello world, it is Jermaine ";
        String h = null;
        System.out.println(s + args[0]); // Hello world, it is Jermaine <args[0]>
        System.out.println(h); // null
        int num = 19;
        float f = 123.45f;
        double d = 123.456D;
        char fig = '{';
        char fig1 = 124;
        char fig2 = 125;
        String numbersCombined = fig + String.valueOf(num) + fig1 + String.valueOf(f) + fig1 + String.valueOf(d) + fig2;
        System.out.println(numbersCombined); // {19|123.45|123.456}
        boolean B = true && false || true ^ false;
        System.out.println(B); // true
        var i = 65_536;
        System.out.println(Integer.MAX_VALUE); // 2147483647
        System.out.println(Integer.MIN_VALUE); // -2147483648
        System.out.println(Math.sqrt(i)); // 256.0
        var a = 123;
        var doub = 123.456;
        System.out.println(getType(a)); // Integer
        System.out.println(getType(doub)); // Double
        doub = 1022;
        System.out.println(doub); // 1022.0
        //doub = "mistake";
        //error: incompatible types:
        //String cannot be converted to double   
        String s1 = "qwerty";
        s1.charAt(1);
        int ab = 123;
        System.out.println(ab-- - --ab); // 2
        System.out.println(--ab - ab--); // 0
        int number = 18; // 10010
        int shift = 1;
        System.out.println(number >> shift); // 1001
        int an = 5; // 101
        int bn = 2; // 010
        System.out.println(an | bn); // 111 = 7
        System.out.println(an & bn); // 000 = 0
        System.out.println(an ^ bn); // 111 = 7
        String q = "qww1"; // 4
        boolean b = q.length() >= 2 || q.charAt(4) == '1';
        //boolean b = q.length() >= 2 | q.charAt(4) == '1';
        //error: q.charAt(4) String index out of range
        System.out.println(b);
        // &(|) - both operands are evaluated; &&(||) - only if first is false, second operand is evaluated
        // Type conversion:
        int im = 123; double dm = im;
        System.out.println(im); // 123
        System.out.println(dm); // 123.0
        dm = 3.1415; im = (int)dm;
        System.out.println(dm); // 3.1415
        System.out.println(im); // 3
        dm = 3.9415; im = (int)dm;
        System.out.println(dm); // 3.9415
        System.out.println(im); // 3
        byte bm = Byte.parseByte("123");
        System.out.println(bm); // 123
        bm = Byte.parseByte("1234");
        System.out.println(bm); // NumberFormatException: Value out of range
    }
    static String getType(Object o){
            return o.getClass().getSimpleName();
    }
}