package com.example.soporte.apicosuming;

import android.content.Intent;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ListView;
import android.widget.Toast;

import java.util.ArrayList;

import Estructuras.Dominio;
import Estructuras.Fabricante;
import JsonParser.JsonFabricante;
import ServerConection.Http;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    ArrayList<Fabricante> fabricantes;
    ListView listviewFabricantes;
    ArrayList<String> strFabricantes = new ArrayList<>();
    ArrayAdapter<String> adapter;
    Button btn;
    Button btnRefresh;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        listviewFabricantes = (ListView) findViewById(R.id.listView);
        adapter = new ArrayAdapter<String>(this, android.R.layout.simple_list_item_1, strFabricantes);
        btn = (Button) findViewById(R.id.button);
        btnRefresh = (Button) findViewById(R.id.refresh);
        btn.setOnClickListener(this);
        btnRefresh.setOnClickListener(this);
        executeGet execute = new executeGet();
        execute.execute();

    }

    @Override
    public void onClick(View v) {
        if (v.getId() == findViewById(R.id.button).getId()) {
            Intent intent = new Intent(this, NuevoFabricante.class);
            startActivity(intent);
        }
        if (v.getId() == findViewById(R.id.refresh).getId()) {
            adapter.clear();
            listviewFabricantes.setAdapter(null);
            Toast.makeText(getApplicationContext(), "Recargando", Toast.LENGTH_SHORT).show();
            executeGet execute = new executeGet();
            execute.execute();
        }
    }


    private class executeGet extends AsyncTask<String, String, String> {
        protected String doInBackground(String... Url) {

            Http connect = new Http();
            String response = connect.HttpGet(Dominio.getInstance().Dominio + "fabricantes");
            JsonFabricante json = new JsonFabricante();
            fabricantes = json.obtenerFabricantes(response);
            return response;
        }

        protected void onPostExecute(String result) {

            for (int i = 0; i < fabricantes.size(); i++) {
                strFabricantes.add(fabricantes.get(i).getNombre() + " " + fabricantes.get(i).getDireccion() + " " + fabricantes.get(i).getTelefono());
            }
            listviewFabricantes.setOnItemClickListener(new AdapterView.OnItemClickListener() {
                @Override
                public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                    Intent intent = new Intent(getApplicationContext(), com.example.soporte.apicosuming.Fabricante.class);
                    Toast.makeText(getApplicationContext(), "ID =" + fabricantes.get(position).getId(), Toast.LENGTH_SHORT).show();
                    Dominio.getInstance().fabricanteid = fabricantes.get(position).getId();
                    startActivity(intent);
                }
            });
            listviewFabricantes.setAdapter(adapter);
        }
    }


}
