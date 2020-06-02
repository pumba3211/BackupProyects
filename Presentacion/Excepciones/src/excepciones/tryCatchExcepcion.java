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
public class tryCatchExcepcion {
    public void ProbarExcepcion() {
        String numero="numero";
        try{
            int numerocast=Integer.parseInt(numero);
            System.out.println(numerocast);
        }catch(Exception exception){
            System.out.println("Hubo un problema al castear el numero "+exception.toString());
            numero="123";
        }
        finally{
            int numerocast=Integer.parseInt(numero);
            System.out.println(numerocast);
        }
    }
}
