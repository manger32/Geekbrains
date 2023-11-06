import java.lang.StringBuilder;
public class strings_example {
    public static void main(String[] args) {
        StringBuilder S = new StringBuilder("-++---++++-----++++++-------++++++++");  // - строка из плюсиков и минусиков, 1 "-", затем 2 "+", потом 3 "---" и так далее"
        var SLength = S.length();
        S.append("--------++++++++++-----------+++++++++++");
        System.out.println(S);
        for (int i = 0; i < SLength; ++i)
        {
            StringBuilder Temp = new StringBuilder();
            Temp.append(S.charAt(i));
	        for (int j = 0; j < SLength; ++j)
            {
                Temp.append(S.charAt(j));
                S.setCharAt(i,S.charAt((int)2*j/(i+1)));
                S.setCharAt((int)2*j/(i+1), Temp.charAt(i % 2));
            }
        }
        System.out.println(S);
    }
}