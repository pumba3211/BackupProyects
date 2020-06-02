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
public class throwExcepcion {
    public void ProbarExcepcion() throws Exception{
        String destino;
        destino = null;
        if(destino == null){
            throw new Exception("El destino es nulo");
        }
    }
}
