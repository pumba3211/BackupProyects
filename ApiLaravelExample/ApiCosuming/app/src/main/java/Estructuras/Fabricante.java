package Estructuras;

import java.util.ArrayList;

/**
 * Created by soporte on 05/07/2016.
 */
public class Fabricante {
    public int id;

    public String nombre;

    public String direccion;

    public int telefono;

    public ArrayList<Aviones> aviones;

    public Fabricante(int id, String nombre, String direccion, int telefono) {
        this.id = id;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getDireccion() {
        return direccion;
    }

    public void setDireccion(String direccion) {
        this.direccion = direccion;
    }

    public int getTelefono() {
        return telefono;
    }

    public void setTelefono(int telefono) {
        this.telefono = telefono;
    }

    public ArrayList<Aviones> getAviones() {
        return aviones;
    }

    public void setAviones(ArrayList<Aviones> aviones) {
        this.aviones = aviones;
    }
}
