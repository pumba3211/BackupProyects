/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package InterfazProyectoMascotaFeliz;

import datos.DueñoDatos;
import datos.RazaDatos;
import datos.año;
import datos.mes;
import datos.dias;
import java.awt.Image;
import java.awt.Toolkit;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.table.DefaultTableModel;
import proyectomascotafeliz.MantenimientoDueño;
import proyectomascotafeliz.MantemimientoRazas;
import proyectomascotafeliz.MantenimientoMascota;
import proyectomascotafeliz.archivo;

/**
 *
 * @author Ronald
 */
public class Mascota extends javax.swing.JFrame {

    private archivo archivo = new archivo();
    MantemimientoRazas conexionRazas;//Conexion a razas
    MantenimientoDueño conexionDueños;//conexions a dueños
    MantenimientoMascota conexionmascotas;//conexion a mascotas
    private DefaultTableModel mascotas;//Modelo de la tabla mascotas
    private JPanel panelInsertar;//Formato para el panel insertar
    private String codigoguardar;//Guarda el codigo de la mascota
    //Sirve para separar la fecha para asignar a las cajas de texto dia,mes,año
    private String separarfecha;
    private String diaseparado = "";
    private String añoseparado = "";
    private String messeparado = "";

    /**
     * Creates new form Mascota
     */
    //Metodo constructor
    public Mascota() {
        archivo.leer();
        try {
            this.conexionmascotas = new MantenimientoMascota(archivo.getBase(), archivo.getUser(), archivo.getPassword());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            this.conexionDueños = new MantenimientoDueño(archivo.getBase(), archivo.getUser(), archivo.getPassword());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            this.conexionRazas = new MantemimientoRazas(archivo.getBase(), archivo.getUser(), archivo.getPassword());
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        } catch (SQLException ex) {
            Logger.getLogger(Especie.class.getName()).log(Level.SEVERE, null, ex);
        }
        initComponents();
        Image icono = Toolkit.getDefaultToolkit().getImage(ClassLoader.getSystemResource(("Iconos/pug-icono-4903-128.png")));
        setIconImage(icono);
        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        llenarcomBoxes();
        cargarMascotas();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        InsertarMascota = new javax.swing.JButton();
        eliminarmascota = new javax.swing.JButton();
        cerrarventana = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tablamascotas = new javax.swing.JTable();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        nombre = new javax.swing.JTextField();
        dia = new javax.swing.JTextField();
        codigomascota = new javax.swing.JTextField();
        mes = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        año = new javax.swing.JTextField();
        ModificarMascota = new javax.swing.JButton();
        comboboxRazas = new javax.swing.JComboBox();
        comboBoxDueños = new javax.swing.JComboBox();
        jButton1 = new javax.swing.JButton();
        jLabel9 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setResizable(false);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        InsertarMascota.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Insertat.png"))); // NOI18N
        InsertarMascota.setBorderPainted(false);
        InsertarMascota.setContentAreaFilled(false);
        InsertarMascota.setRolloverIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Insertat2.png"))); // NOI18N
        InsertarMascota.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                InsertarMascotaActionPerformed(evt);
            }
        });
        getContentPane().add(InsertarMascota, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 140, 150, -1));

        eliminarmascota.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Eliminar.png"))); // NOI18N
        eliminarmascota.setBorderPainted(false);
        eliminarmascota.setContentAreaFilled(false);
        eliminarmascota.setRolloverIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Eliminar2.png"))); // NOI18N
        eliminarmascota.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                eliminarmascotaActionPerformed(evt);
            }
        });
        getContentPane().add(eliminarmascota, new org.netbeans.lib.awtextra.AbsoluteConstraints(180, 140, 140, -1));

        cerrarventana.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Cerrar.png"))); // NOI18N
        cerrarventana.setBorderPainted(false);
        cerrarventana.setContentAreaFilled(false);
        cerrarventana.setRolloverIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Cerrar2.png"))); // NOI18N
        cerrarventana.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cerrarventanaActionPerformed(evt);
            }
        });
        getContentPane().add(cerrarventana, new org.netbeans.lib.awtextra.AbsoluteConstraints(881, 530, 140, 60));

        tablamascotas.setSelectionBackground(new java.awt.Color(204, 204, 204));
        tablamascotas.setSelectionForeground(new java.awt.Color(102, 102, 102));
        tablamascotas.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tablamascotasMouseClicked(evt);
            }
        });
        tablamascotas.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyPressed(java.awt.event.KeyEvent evt) {
                tablamascotasKeyPressed(evt);
            }
        });
        jScrollPane1.setViewportView(tablamascotas);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 190, 679, 390));

        jLabel1.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(240, 240, 240));
        jLabel1.setText("Nombre");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 190, -1, -1));

        jLabel2.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(240, 240, 240));
        jLabel2.setText("Fecha");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(701, 209, -1, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(240, 240, 240));
        jLabel3.setText("Codigo Raza");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(693, 320, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(240, 240, 240));
        jLabel4.setText("Cedula Propietario");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(693, 348, -1, -1));

        jLabel5.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(240, 240, 240));
        jLabel5.setText("Codigo Mascota");
        getContentPane().add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(693, 378, -1, -1));

        nombre.setSelectedTextColor(new java.awt.Color(102, 102, 102));
        nombre.setSelectionColor(new java.awt.Color(204, 204, 204));
        getContentPane().add(nombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 190, 150, -1));

        dia.setSelectedTextColor(new java.awt.Color(102, 102, 102));
        dia.setSelectionColor(new java.awt.Color(204, 204, 204));
        getContentPane().add(dia, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 220, 26, -1));

        codigomascota.setSelectedTextColor(new java.awt.Color(102, 102, 102));
        codigomascota.setSelectionColor(new java.awt.Color(204, 204, 204));
        getContentPane().add(codigomascota, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 380, 160, -1));

        mes.setSelectedTextColor(new java.awt.Color(102, 102, 102));
        mes.setSelectionColor(new java.awt.Color(204, 204, 204));
        getContentPane().add(mes, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 250, 26, -1));

        jLabel6.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel6.setForeground(new java.awt.Color(240, 240, 240));
        jLabel6.setText("Dia");
        getContentPane().add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(701, 232, -1, -1));

        jLabel7.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel7.setForeground(new java.awt.Color(240, 240, 240));
        jLabel7.setText("Mes");
        getContentPane().add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(701, 258, -1, -1));

        jLabel8.setFont(new java.awt.Font("Tahoma", 0, 18)); // NOI18N
        jLabel8.setForeground(new java.awt.Color(240, 240, 240));
        jLabel8.setText("Año");
        getContentPane().add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(701, 284, -1, -1));

        año.setSelectedTextColor(new java.awt.Color(102, 102, 102));
        año.setSelectionColor(new java.awt.Color(204, 204, 204));
        getContentPane().add(año, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 280, 54, -1));

        ModificarMascota.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Modificar.png"))); // NOI18N
        ModificarMascota.setBorderPainted(false);
        ModificarMascota.setContentAreaFilled(false);
        ModificarMascota.setRolloverIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Modificar2.png"))); // NOI18N
        ModificarMascota.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ModificarMascotaActionPerformed(evt);
            }
        });
        getContentPane().add(ModificarMascota, new org.netbeans.lib.awtextra.AbsoluteConstraints(840, 410, -1, -1));
        getContentPane().add(comboboxRazas, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 320, 157, -1));
        getContentPane().add(comboBoxDueños, new org.netbeans.lib.awtextra.AbsoluteConstraints(850, 350, 157, -1));

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Dueño/Mascota.png"))); // NOI18N
        jButton1.setBorderPainted(false);
        jButton1.setContentAreaFilled(false);
        jButton1.setRolloverIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/Dueño/Mascota2.png"))); // NOI18N
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 1030, 100));

        jLabel9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Diseños/fondo-madera-negro.jpg"))); // NOI18N
        getContentPane().add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 100, 1030, 510));

        pack();
    }// </editor-fold>//GEN-END:initComponents
    //Se cierra la ventana
    private void cerrarventanaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cerrarventanaActionPerformed
        // TODO add your handling code here:
        dispose();
    }//GEN-LAST:event_cerrarventanaActionPerformed
    //Se le asigna valores a las cajas de texto a la hora de seleccionar con el mouse el lugar en la tabla
    private void tablamascotasMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tablamascotasMouseClicked
        // TODO add your handling code here:
        int cont = 0;
        nombre.setText((String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 0));
        separarfecha = (String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 1);
        separafecha(separarfecha);
        añoseparado = "";
        diaseparado = "";
        messeparado = "";
        codigomascota.setText((String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 6));
        codigoguardar = (String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 6);
    }//GEN-LAST:event_tablamascotasMouseClicked
    //Accion del boton Insertar
    private void InsertarMascotaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_InsertarMascotaActionPerformed
        // TODO add your handling code here:
        panelInsertar = new JPanel();
        //Se añaden los componentes al panel insertar
        JButton insertar = new JButton("Insertar");
        JLabel nombre = new JLabel("Nombre");
        JLabel fechanacimiento = new JLabel("Fecha Nacimiento");
        JLabel codigoraza = new JLabel("Codigo raza");
        JLabel cedula = new JLabel("Cedula Dueño");
        JLabel codmascota = new JLabel("Codigo Mascota");
        JTextField txtNombre = new JTextField(10);
        JComboBox comboBoxdias = new JComboBox();
        //Se llenan los combobox dia,mes,año,raza y dueño
        try {
            for (int x = 0; x < diasmes().size(); x++) {
                comboBoxdias.addItem(diasmes().get(x).getDia());
            }
        } catch (SQLException ex) {
            Logger.getLogger(Mascota.class.getName()).log(Level.SEVERE, null, ex);
        }
        JComboBox comboBoxmeses = new JComboBox();
        for (int i = 0; i < mesesaño().size(); i++) {
            comboBoxmeses.addItem(mesesaño().get(i).getMes());
        }
        JComboBox comboBoxaños = new JComboBox();
        for (int j = 0; j < años().size(); j++) {
            comboBoxaños.addItem(años().get(j).getAño());
        }
        JComboBox comboBoxrazas = new JComboBox();
        try {
            for (int x = 0; x < RazasDatos().size(); x++) {
                comboBoxrazas.addItem(RazasDatos().get(x).getCod_raza() + " " + RazasDatos().get(x).getNombre());
            }
        } catch (SQLException ex) {
            Logger.getLogger(Razas.class.getName()).log(Level.SEVERE, null, ex);
        }
        JComboBox comboBoxCedulas = new JComboBox();
        try {
            for (int x = 0; x < DueñosDatos().size(); x++) {
                comboBoxCedulas.addItem(DueñosDatos().get(x).getCedula() + " " + DueñosDatos().get(x).getNombre() + DueñosDatos().get(x).getApellido1() + DueñosDatos().get(x).getApellido2());
            }
        } catch (SQLException ex) {
            Logger.getLogger(Razas.class.getName()).log(Level.SEVERE, null, ex);
        }
        JTextField txtCodigomascota = new JTextField(10);

        panelInsertar.add(nombre);
        panelInsertar.add(txtNombre);
        panelInsertar.add(fechanacimiento);
        panelInsertar.add(comboBoxdias);
        panelInsertar.add(comboBoxmeses);
        panelInsertar.add(comboBoxaños);
        panelInsertar.add(codigoraza);
        panelInsertar.add(comboBoxrazas);
        panelInsertar.add(cedula);
        panelInsertar.add(comboBoxCedulas);
        panelInsertar.add(codmascota);
        panelInsertar.add(txtCodigomascota);
        //Se inserta en la base de datos la nueva mascota
        JOptionPane.showConfirmDialog(null, panelInsertar, "Insertar Mascota", JOptionPane.PLAIN_MESSAGE);
        String datos;
        String estado;
        try {
            datos = "('" + txtNombre.getText() + "','" + (diasmes().get(comboBoxdias.getSelectedIndex()).getDia() + "/"
                    + mesesaño().get(comboBoxmeses.getSelectedIndex()).getMes() + "/" + años().get(comboBoxaños.getSelectedIndex()).getAño())
                    + "','" + RazasDatos().get(comboBoxrazas.getSelectedIndex()).getCod_raza()
                    + "','" + DueñosDatos().get(comboBoxCedulas.getSelectedIndex()).getCedula() + "','" + txtCodigomascota.getText() + "')";
            estado = conexionmascotas.Insertar("\"schProyecto\".\"mascota\"", datos);
            JOptionPane.showMessageDialog(null, "Datos insertado con exito");
            cargarMascotas();
        } catch (SQLException ex) {
            Logger.getLogger(Razas.class.getName()).log(Level.SEVERE, null, ex);
        }


    }//GEN-LAST:event_InsertarMascotaActionPerformed
    //Se elimina la mascota seleccionada en la tabla
    private void eliminarmascotaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_eliminarmascotaActionPerformed
        // TODO add your handling code here:
        String estado;

        estado = this.conexionmascotas.eliminar("\"schProyecto\".\"mascota\"", String.valueOf(tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 6)));
        cargarMascotas();
        JOptionPane.showMessageDialog(null, "Datos eliminados");
        codigomascota.setText("");
        nombre.setText("");
        año.setText("");
        mes.setText("");
        dia.setText("");

    }//GEN-LAST:event_eliminarmascotaActionPerformed
    //se modifica los datos de las mascotas basandose en las cajas de texto
    private void ModificarMascotaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ModificarMascotaActionPerformed
        // TODO add your handling code here:
        String estado;

//        estado =conexionmascotas.Modificar("\"schProyecto\".\"mascota\"", codigomascota.getText(),nombre.getText(),(año.getText()+"-"+mes.getText()+"-"+dia.getText())
//                        ,raza.getText(),propietario.getText(),codigoguardar);
//               
        cargarMascotas();
        JOptionPane.showMessageDialog(null, "Datos modificados con exito");
        codigomascota.setText("");
        nombre.setText("");
        año.setText("");
        mes.setText("");
        dia.setText("");


    }//GEN-LAST:event_ModificarMascotaActionPerformed

    private void tablamascotasKeyPressed(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_tablamascotasKeyPressed
        // TODO add your handling code here:
        int cont = 0;
        nombre.setText((String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 0));
        separarfecha = (String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 1);
        separafecha(separarfecha);
        añoseparado = "";
        diaseparado = "";
        messeparado = "";
        codigomascota.setText((String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 6));
        codigoguardar = (String) tablamascotas.getValueAt(tablamascotas.getSelectedRow(), 6);
    }//GEN-LAST:event_tablamascotasKeyPressed
    //Se cargan las mascotas de la tabla mascotas de la base de datos
    public void cargarMascotas() {
        mascotas = new DefaultTableModel();
        mascotas.addColumn("Nombre");
        mascotas.addColumn("Fecha Nacimiento");
        mascotas.addColumn("Codigo Raza");
        mascotas.addColumn("Nombre Raza");
        mascotas.addColumn("Cedula Propietario");
        mascotas.addColumn("Nombre Propietario");
        mascotas.addColumn("Codigo Mascota");

        ResultSet datos = conexionmascotas.select2();
        try {

            while (datos.next()) {
                String[] valores = {datos.getString("nombre_mascota"), datos.getString("fecha_nacimiento"), datos.getString("cod_raza"), datos.getString("nombre_raza"), datos.getString("cedula"), datos.getString("nombre"), datos.getString("cod_mascota")};
                mascotas.addRow(valores);
            }
            tablamascotas.setModel(mascotas);

        } catch (Exception e) {

            System.out.println("Error: " + e.toString());
        }
    }

    //Se llena una array list con los datos de los dueños registras
    public ArrayList<DueñoDatos> DueñosDatos() throws SQLException {

        ResultSet datos = conexionDueños.select("*", "\"schProyecto\".\"dueno\"", "");
        ArrayList<DueñoDatos> dueños = new ArrayList();
        while (datos.next()) {

            DueñoDatos dueño = new DueñoDatos(datos.getString("cedula"), datos.getString("nombre"), datos.getString("apellido1"),
                    datos.getString("apellido2"), datos.getString("telefono"), datos.getString("direccion"));
            dueños.add(dueño);
        }
        return dueños;
    }

    //Se llena una array list con los datos de las razas registradas
    public ArrayList<RazaDatos> RazasDatos() throws SQLException {

        ResultSet datos = conexionRazas.select("*", "\"schProyecto\".\"raza\"", "");
        ArrayList<RazaDatos> razas = new ArrayList();
        while (datos.next()) {

            RazaDatos raza = new RazaDatos(datos.getString("cod_raza"), datos.getString("cod_especie"), datos.getString("nombre_raza"));
            razas.add(raza);
        }
        return razas;
    }

    //Se llena una array list de dias al mes
    public ArrayList<dias> diasmes() throws SQLException {
        ArrayList<dias> dias = new ArrayList();
        for (int i = 1; i <= 31; i++) {
            dias dia = new dias(i);
            dias.add(dia);
        }
        return dias;
    }

    //Se llena una array list con los datos meses al año
    public ArrayList<mes> mesesaño() {
        ArrayList<mes> meses = new ArrayList();
        for (int i = 1; i <= 12; i++) {
            mes mes = new mes(i);
            meses.add(mes);
        }
        return meses;
    }

    //Se llena una array list con los años
    public ArrayList<año> años() {
        ArrayList<año> años = new ArrayList();
        for (int i = 1980; i <= 2013; i++) {
            año año = new año(i);
            años.add(año);
        }
        return años;
    }

    //MEtodo que sirve para separar la fecha seleccionada
    public void separafecha(String dato) {
        int cont = 0;
        while (dato.charAt(cont) != '-') {
            añoseparado = añoseparado + dato.charAt(cont);
            cont++;
        }

        cont++;
        while (dato.charAt(cont) != '-') {
            messeparado = messeparado + dato.charAt(cont);
            cont++;
        }

        cont++;
        while (cont < dato.length()) {
            diaseparado = diaseparado + dato.charAt(cont);
            cont++;
        }
        dia.setText(diaseparado);
        mes.setText(messeparado);
        año.setText(añoseparado);
    }

    //Metodo que llena los comboboxes de razas y dueños de la ventana
    public void llenarcomBoxes() {
        try {
            for (int x = 0; x < RazasDatos().size(); x++) {
                comboboxRazas.addItem(RazasDatos().get(x).getCod_raza() + " " + RazasDatos().get(x).getNombre());
            }
        } catch (SQLException ex) {
            Logger.getLogger(Razas.class.getName()).log(Level.SEVERE, null, ex);
        }
        try {
            for (int x = 0; x < DueñosDatos().size(); x++) {
                comboBoxDueños.addItem(DueñosDatos().get(x).getCedula() + " " + DueñosDatos().get(x).getNombre() + DueñosDatos().get(x).getApellido1() + DueñosDatos().get(x).getApellido2());
            }
        } catch (SQLException ex) {
            Logger.getLogger(Razas.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Mascota.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Mascota.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Mascota.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Mascota.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Mascota().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton InsertarMascota;
    private javax.swing.JButton ModificarMascota;
    private javax.swing.JTextField año;
    private javax.swing.JButton cerrarventana;
    private javax.swing.JTextField codigomascota;
    private javax.swing.JComboBox comboBoxDueños;
    private javax.swing.JComboBox comboboxRazas;
    private javax.swing.JTextField dia;
    private javax.swing.JButton eliminarmascota;
    private javax.swing.JButton jButton1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextField mes;
    private javax.swing.JTextField nombre;
    private javax.swing.JTable tablamascotas;
    // End of variables declaration//GEN-END:variables
}
