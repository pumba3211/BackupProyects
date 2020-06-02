package com.example.soporte.apicosuming;

import android.os.AsyncTask;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;

import java.util.ArrayList;

import Estructuras.Dominio;
import JsonParser.JsonFabricante;
import ServerConection.Http;

public class Fabricante extends AppCompatActivity implements View.OnClickListener {
    EditText txtNombre;
    EditText txtDireccion;
    EditText txtTelefono;
    Button btnEditar;
    ListView listviewAviones;
    ArrayList<String> strAviones = new ArrayList<>();
    ArrayAdapter<String> adapter;
    Estructuras.Fabricante fabricante;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fabricante);
        txtNombre = (EditText) findViewById(R.id.editText);
        txtDireccion = (EditText) findViewById(R.id.editText2);
        txtTelefono = (EditText) findViewById(R.id.editText3);
        btnEditar = (Button) findViewById(R.id.button3);
        listviewAviones = (ListView) findViewById(R.id.listView2);
        adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, strAviones);
        btnEditar.setOnClickListener(this);
        executeGet executeget = new executeGet();
        executeget.execute();
    }

    @Override
    public void onClick(View v) {
        if (v.getId() == findViewById(R.id.button3).getId()) {
            executeGet executeget = new executeGet();
            executeget.execute();
        }
    }

    private class executeGet extends AsyncTask<String, String, String> {
        protected String doInBackground(String... Url) {

            Http connect = new Http();
            String response = connect.HttpGet(Dominio.getInstance().Dominio + "fabricantes/" + Dominio.getInstance().fabricanteid);
            JsonFabricante json = new JsonFabricante();
            fabricante = json.obtenerFabricante(response);
            return "";
        }

        protected void onPostExecute(String result) {
            txtNombre.setText(fabricante.getNombre());
            txtDireccion.setText(fabricante.getDireccion());
            txtTelefono.setText(""+fabricante.getTelefono());
            for (int i = 0; i < fabricante.aviones.size(); i++) {
                strAviones.add(fabricante.aviones.get(i).getModelo() + " " + fabricante.aviones.get(i).getCapacidad() + " " + fabricante.aviones.get(i).getAlcance());
            }
            listviewAviones.setAdapter(adapter);
        }
    }
}
