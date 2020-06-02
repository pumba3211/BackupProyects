package com.example.sopor.autocompletartexto;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.AutoCompleteTextView;
import android.widget.EditText;

public class MainActivity extends AppCompatActivity {
    AutoCompleteTextView editText2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        editText2= (AutoCompleteTextView)findViewById(R.id.editText2);
        llenarOpcionesEditText(editText2);
    }
    public void llenarOpcionesEditText(AutoCompleteTextView editText){
        String[] saludos = getResources().getStringArray(R.array.valsAutoComplete);
        ArrayAdapter<String> adapter = new ArrayAdapter<String>(this,android.R.layout.simple_list_item_1,saludos);
        editText.setAdapter(adapter);
    }
}
