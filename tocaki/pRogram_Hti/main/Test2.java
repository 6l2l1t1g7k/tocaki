package main;

import java.util.ArrayList;

public class Test2 {
    public static void main(final String[] args) throws Exception {
        ArrayList<Integer> Token = new ArrayList<>();
        Token.add(5);
        Token.add(9);
        Token.add(5);
        Token.add(1);

        Boolean ok;
        //Test1 7819 : 2 chiffres sont bon mais mal placé
        int nb = 0;
        if(Token.get(0)==8 || Token.get(0)==1 || Token.get(0)==9){
            nb += 1;
        }
        if(Token.get(1)==7 || Token.get(1)==1 || Token.get(1)==9){
            nb += 1;
        }
        if(Token.get(2)==7 || Token.get(2)==8 || Token.get(2)==9){
            nb += 1;
        }
        if(Token.get(3)==7 || Token.get(3)==8 || Token.get(3)==1){
            nb += 1;
        }

        if (nb == 2){
            ok = true;
        }else{
            ok = false;
        }

        if(ok){
            //Test2 4723 : aucun chiffre n'est bon
            for (int j = 0; j < 4 ; j++) {
                if(Token.get(j)==4 || Token.get(j)==7 || Token.get(j)==2 || Token.get(j)==3){
                    ok = false;
                }
            }

            if(ok) {
                //Test3 0451 : 1 chiffre bon et mal placé
                nb=0;
                if(Token.get(0)==4 || Token.get(0)==5 || Token.get(0)==1){
                    nb += 1;
                    System.out.println(nb);
                }
                if(Token.get(1)==0 || Token.get(1)==5 || Token.get(1)==1){
                    nb += 1;
                    System.out.println(nb);
                }
                if(Token.get(2)==0 || Token.get(2)==4 || Token.get(2)==1){
                    nb += 1;
                    System.out.println(nb);
                }
                if(Token.get(3)==0 || Token.get(3)==4 || Token.get(3)==5){
                    nb += 1;
                    System.out.println(nb);
                }
                if (nb == 1){
                    ok = true;
                }else{
                    ok = false;
                }


                if (ok) {
                    //Test4 5946 : 2 chiffres bon et bien placé
                    nb=0;
                    if(Token.get(0)==5){
                        nb += 1;
                    }
                    if(Token.get(1)==9){
                        nb += 1;
                    }
                    if(Token.get(2)==4){
                        nb += 1;
                    }
                    if(Token.get(3)==6){
                        nb += 1;
                    }

                    if (nb == 2){
                        ok = true;
                    }else{
                        ok = false;
                    }

                    if (ok) {
                        //Test5 2 chiffres sont identiques
                        nb=0;
                        if(Token.get(0)==Token.get(1)){
                            nb += 1;
                        }
                        if(Token.get(0)==Token.get(2)){
                            nb += 1;
                        }
                        if(Token.get(0)==Token.get(3)){
                            nb += 1;
                        }
                        if(Token.get(1)==Token.get(2)){
                            nb += 1;
                        }
                        if(Token.get(1)==Token.get(3)){
                            nb += 1;
                        }
                        if(Token.get(2)==Token.get(3)){
                            nb += 1;
                        }

                        if (nb == 1){
                            ok = true;
                        }else{
                            ok = false;
                        }

                        if (ok) {
                            System.out.println("Valid");
                        }
                    }
                }
            }
        }
        }
}
