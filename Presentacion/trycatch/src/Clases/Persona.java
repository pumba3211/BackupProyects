/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

/**
 *
 * @author ronald
 */
public class Persona {

    public int id;
    public String cedula;
    public String Nombre;
    public String Apellidos;
    public int años;

    public Persona(int id, String cedula, String Nombre, String Apellidos, int años) {
        this.id = id;
        this.cedula = cedula;
        this.Nombre = Nombre;
        this.Apellidos = Apellidos;
        this.años = años;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getCedula() {
        return cedula;
    }

    public void setCedula(String cedula) {
        this.cedula = cedula;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getApellidos() {
        return Apellidos;
    }

    public void setApellidos(String Apellidos) {
        this.Apellidos = Apellidos;
    }

    public int getAños() {
        return años;
    }

    public void setAños(int años) {
        this.años = años;
    }

}
