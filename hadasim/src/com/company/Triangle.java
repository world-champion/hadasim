package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Triangle extends UserInterface {
    public static double calculatePerimeter(double baseLength, double height) {
        double sideLength = Math.sqrt(Math.pow(baseLength / 2, 2) + Math.pow(height, 2));
        double perimeter = 2 * sideLength + baseLength;

        return perimeter;
    }

    public void showPerimeter(double width, double height, JPanel panel) {

        panel.add(new JLabel("the perimeter of triangle building is: " + (calculatePerimeter(width, height))));
        panel.revalidate();
        panel.repaint();
    }

    public static void showTriangle(int height, int width, JPanel panel) {
        panel.setLayout(new GridLayout(height, width));
        int count = (height - 2) / (width / 2 - 1), tempCount = count + ((height - 2) % (width / 2 - 1)), nowOdd = 3;
        for (int row = 1; row <= height; row++) {
            if (tempCount == 0) {
                tempCount = count;
                nowOdd += 2;
            }
            int numSpaces = 0;
            if (row == 1) {
                numSpaces = (width - row) / 2;
            } else if (row != height) {
                tempCount--;
                numSpaces = (width - nowOdd) / 2;
            }
            for (int col = 0; col < width; col++) {
                String text = "";
                if (col >= numSpaces && col < width - numSpaces) {
                    text = "*";
                }
                JLabel label = new JLabel(text);
                label.setBorder(BorderFactory.createEmptyBorder(0, 0, 0, 0));
                panel.add(label);
                panel.revalidate();
                panel.repaint();
            }
        }
    }

    public void triangleInput() {
        getContentPane().removeAll();
        inputPanel = new JPanel(new GridLayout(2, 2));
        JTextField baseFeild = new JTextField();
        heightFeild = new JTextField();
        widthFeild = new JTextField();
        inputPanel.add(new JLabel("base:"));
        inputPanel.add(widthFeild);
        inputPanel.add(new JLabel("Height:"));
        inputPanel.add(heightFeild);
        sendButton = new JButton("send");
        sendButton.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                triangleOption(inputPanel);
            }

        });

        getContentPane().add(inputPanel, BorderLayout.PAGE_START);

        getContentPane().add(sendButton, BorderLayout.AFTER_LAST_LINE);

        revalidate();

        repaint();
    }

    public void triangleOption(JPanel contentPane) {
        contentPane.removeAll();
        JPanel panel = new JPanel(new GridLayout(3, 1));
//        contentPane.setLayout(new FlowLayout());
        contentPane.add(new JLabel("Please choose what you want to see:"));
        JRadioButton option1 = new JRadioButton("Triangle");
        option1.addActionListener((new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent e) {
                print(1);
            }
        }));
        JRadioButton option2 = new JRadioButton("Triangle perimeter");
        option2.addActionListener((new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                print(2);
            }
        }));
        panel.add(option1);
        panel.add(option2);
        contentPane.add(panel);
        contentPane.revalidate();
        contentPane.repaint();

    }

    public void print(int option) {
        JPanel panel = new JPanel();
        JFrame newWindow = new JFrame();
        newWindow.setName("result");
        newWindow.setTitle("the result");
        newWindow.setAlwaysOnTop(true);
        if (widthFeild.getText() != "" && heightFeild.getText() != "" && option == 1)
            if (Integer.parseInt(widthFeild.getText()) % 2 == 0)
                panel.add(new JLabel("you cant enter odd base length"));
            else if (Integer.parseInt(heightFeild.getText()) * 2 < Integer.parseInt(widthFeild.getText()))
                panel.add(new JLabel("the height length have to be at most half from the base length"));
            else
                showTriangle(Integer.parseInt(heightFeild.getText()), Integer.parseInt(widthFeild.getText()), panel);
        else if (widthFeild.getText() != "" && heightFeild.getText() != "" && option == 2)
            showPerimeter(Integer.parseInt(heightFeild.getText()), Integer.parseInt(widthFeild.getText()), panel);
        newWindow.add(panel);
        newWindow.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        newWindow.pack();
        newWindow.setLocationRelativeTo(this);
        newWindow.setVisible(true);
        Main.init();

    }
}
