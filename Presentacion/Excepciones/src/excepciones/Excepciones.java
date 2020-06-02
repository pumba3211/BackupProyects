/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package excepciones;

/**
 *
 * @author Ronald
 */
public class Excepciones {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws Exception {
        int caso=1;
        switch(caso){
            case 1:
                (new throwExcepcion()).ProbarExcepcion();
                break;
            case 2:
                (new tryCatchExcepcion()).ProbarExcepcion();
                break;
        }
    }
    
}
