package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Rectangle extends UserInterface{
    public Rectangle() {
        super();
    }

    static void calcPerimeter(double height, double width, JPanel panel){
    panel.add(new JLabel("the perimeter is:" +height*width));

}
static void calcArea(double height, double width, JPanel panel){
    panel.add(new JLabel("the area is:" +height*width));
    }

    public Dimension getSizes() {
        getContentPane().removeAll();
    inputPanel = new JPanel(new GridLayout(2, 2));
    widthFeild = new JTextField();
    heightFeild = new JTextField();
        inputPanel.add(new JLabel("width:"));
        inputPanel.add(widthFeild);
        inputPanel.add(new JLabel("Height:"));
        inputPanel.add(heightFeild);
    sendButton = new JButton("send");
        sendButton.addActionListener(new ActionListener() {
        public void actionPerformed(ActionEvent e) {
            print();
        }

    });

    getContentPane().add(inputPanel, BorderLayout.PAGE_START);

    getContentPane().add(sendButton, BorderLayout.AFTER_LAST_LINE);

    revalidate();

    repaint();
        return null;
    }
    public void print(){
        JPanel panel = new JPanel();
        JFrame newWindow = new JFrame();
            newWindow.setName("result");
            newWindow.setTitle("the result");
            newWindow.setAlwaysOnTop(true);
            if (widthFeild.getText()!="" && heightFeild.getText()!="" &&  Math.abs( Integer.parseInt(widthFeild.getText())-Integer.parseInt(heightFeild.getText()))>5)
                Rectangle.calcArea(Integer.parseInt(heightFeild.getText()),  Integer.parseInt(widthFeild.getText()), panel);
            else
                Rectangle.calcPerimeter(Integer.parseInt(heightFeild.getText()),  Integer.parseInt(widthFeild.getText()), panel);
        newWindow.add(panel);
        newWindow.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        newWindow.pack();
        newWindow.setLocationRelativeTo(this);
        newWindow.setVisible(true);
        Main.init();

    }
}
