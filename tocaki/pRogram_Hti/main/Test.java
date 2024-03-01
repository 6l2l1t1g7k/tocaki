// 
// Decompiled by Procyon v0.5.36
// 

package main;

import java.util.ArrayList;
import java.util.Arrays;

public class Test {
    public static void main(final String[] args) throws Exception {
        ArrayList<ArrayList<Integer>> ListCode = new ArrayList<>();
        ArrayList<ArrayList<Integer>> CodeValid = new ArrayList<>();
        ArrayList<Integer> token = new ArrayList<>();
        token.add(0);
        token.add(0);
        token.add(0);
        token.add(0);
        ListCode.add((ArrayList<Integer>) token.clone());


        for (int i = 1; i < 10000; i++) {
            // iteration to create the 9999 other numbers
            int t = i;
            token.set(0, t / 1000);
            t -= t / 1000 * 1000;
            token.set(1, t / 100);
            t -= t / 100 * 100;
            token.set(2, t / 10);
            t -= t / 10 * 10;
            token.set(3, t);


            // creation de la liste des 10000 nbr
            ListCode.add((ArrayList<Integer>) token.clone());

            //suite
            Boolean ok = true;

            ArrayList<Integer> modele = new ArrayList<>();
            modele.add(0);
            modele.add(0);
            modele.add(0);
            modele.add(0);

            //Test1 7819 : 2 chiffres sont bon mais mal placé
            modele.set(0,7);
            modele.set(1,8);
            modele.set(2,1);
            modele.set(3,9);

            if(correspondance(token,modele)[0] != 0 || correspondance(token,modele)[1] != 2){
                ok = false;
            }
            if (ok) {
                //Test2 4723 : aucun chiffre n'est bon
                modele.set(0,4);
                modele.set(1,7);
                modele.set(2,2);
                modele.set(3,3);

                if(correspondance(token,modele)[0] != 0 || correspondance(token,modele)[1] != 0){
                    ok = false;
                }

                    if (ok) {
                        //Test3 0451 : 1 chiffre bon et mal placé
                        modele.set(0,0);
                        modele.set(1,4);
                        modele.set(2,5);
                        modele.set(3,1);

                        if(correspondance(token,modele)[0] != 0 || correspondance(token,modele)[1] != 1){
                            ok = false;
                        }

                        if (ok) {
                            //Test4 5946 : 2 chiffres bon et bien placé
                            modele.set(0,5);
                            modele.set(1,9);
                            modele.set(2,4);
                            modele.set(3,6);

                            if(correspondance(token,modele)[0] != 2 || correspondance(token,modele)[1] != 0){
                                ok = false;
                            }

                            if (ok) {
                                //Test5 2 chiffres sont identiques
                                int identique = 0;
                                if (token.get(0) == token.get(1)) {
                                    identique += 1;
                                }
                                if (token.get(0) == token.get(2)) {
                                    identique += 1;
                                }
                                if (token.get(0) == token.get(3)) {
                                    identique += 1;
                                }
                                if (token.get(1) == token.get(2)) {
                                    identique += 1;
                                }
                                if (token.get(1) == token.get(3)) {
                                    identique += 1;
                                }
                                if (token.get(2) == token.get(3)) {
                                    identique += 1;
                                }
                                if (identique != 1){
                                    ok = false;
                                }

                                if (ok) {
                                    CodeValid.add((ArrayList<Integer>) token.clone());
                                }
                            }
                        }
                    }
            }
        }
        //System.out.println(ListCode);
        System.out.println(CodeValid);

        ArrayList<Integer> mod = new ArrayList<>();
        mod.add(5);
        mod.add(9);
        mod.add(4);
        mod.add(6);

        ArrayList<Integer> nbr = new ArrayList<>();
        nbr.add(0);
        nbr.add(0);
        nbr.add(1);
        nbr.add(9);

        //System.out.print(correspondance(nbr,mod)[0]);System.out.print(correspondance(nbr,mod)[1]);

    }

    // Result [x,y]
    // x est le nombre de chiffres correct à la place corrrecte
    // y est le nombre de chiffres correct à une place incorrecte
    public static int[] correspondance(ArrayList<Integer> nombreSrc, ArrayList<Integer> modeleSrc
                               ) {
        ArrayList<Integer> nombre = (ArrayList<Integer>) nombreSrc.clone();
        ArrayList<Integer> modele = (ArrayList<Integer>) modeleSrc.clone();
        int chiffreCorrect = 0;
        int chiffrePseudoCorrect = 0;
        ArrayList<Integer> result = new ArrayList<>();
        for (int i = 0; i < nombre.size(); i++) {
            if (nombre.get(i) == modele.get(i)) {
                chiffreCorrect += 1;
                nombre.remove(i);
                modele.remove(i);
                i--;
            }
        }
        for (int i = 0; i < nombre.size(); i++) {
            for (int j = 0; j < modele.size(); j++) {
                if(nombre.get(i) == modele.get(j)){
                    chiffrePseudoCorrect += 1;
                    modele.remove(j);
                }
            }
        }
        return new int[]{chiffreCorrect, chiffrePseudoCorrect};
    }
}
