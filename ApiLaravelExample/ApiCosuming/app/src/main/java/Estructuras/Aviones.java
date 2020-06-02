package Estructuras;

/**
 * Created by soporte on 05/07/2016.
 */
public class Aviones {
    public int serie;

    public String modelo;

    public float logintud;

    public int capacidad;

    public int velocidad;

    public int alcance;

    public int fabricante_id;

    public Aviones(int serie, String modelo, float logintud, int capacidad, int velocidad, int alcance, int fabricante_id) {
        this.serie = serie;
        this.modelo = modelo;
        this.logintud = logintud;
        this.capacidad = capacidad;
        this.velocidad = velocidad;
        this.alcance = alcance;
        this.fabricante_id = fabricante_id;
    }

    public int getSerie() {
        return serie;
    }

    public void setSerie(int serie) {
        this.serie = serie;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public float getLogintud() {
        return logintud;
    }

    public void setLogintud(float logintud) {
        this.logintud = logintud;
    }

    public int getCapacidad() {
        return capacidad;
    }

    public void setCapacidad(int capacidad) {
        this.capacidad = capacidad;
    }

    public int getVelocidad() {
        return velocidad;
    }

    public void setVelocidad(int velocidad) {
        this.velocidad = velocidad;
    }

    public int getAlcance() {
        return alcance;
    }

    public void setAlcance(int alcance) {
        this.alcance = alcance;
    }

    public int getFabricante_id() {
        return fabricante_id;
    }

    public void setFabricante_id(int fabricante_id) {
        this.fabricante_id = fabricante_id;
    }
}
