package com.company;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.image.BufferedImage;
import java.io.IOException;


public class UserInterface extends JFrame {
    protected JRadioButton option1, option2;
    protected JButton option3, sendButton;
    protected JPanel inputPanel;
    protected JTextField heightFeild, widthFeild;

    public UserInterface() {
        Window[] windows = Window.getWindows();
        for (Window window : windows) {
            if (!window.getName().equals("result"))
                window.dispose();
        }
        setTitle("Investigation of types of towers");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        //אם הייתי רוצה שרק כאשר המשתמש יילחץ על האופציה השלישית תהיה יציאה
        //setDefaultCloseOperation(JFrame.DO_NOTHING_ON_CLOSE);
        setSize(400, 300);
        setLocationRelativeTo(null);
        buildTheBoard();
    }

    public void buildTheBoard() {
        JPanel panel = new JPanel(new GridLayout(3, 1));
        ButtonGroup group = new ButtonGroup();
        option1 = new JRadioButton();
        option1.setIcon(getScaledImageIcon("rectangle.png", 50, 50));
        option1.addActionListener(new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                Rectangle recOption=new Rectangle();
                recOption.getSizes();
            }
        });
        group.add(option1);
        panel.add(option1);
        option2 = new JRadioButton();
        option2.setIcon(getScaledImageIcon("triangle.png", 50, 50));
        option2.addActionListener(new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                Triangle triangleOption=new Triangle();
                triangleOption.triangleInput();
            }
        });
        group.add(option2);
        panel.add(option2);
        option3 = new JButton("exit");
        option3.addActionListener(new AbstractAction() {
            @Override
            public void actionPerformed(ActionEvent actionEvent) {
                dispose();
            }
        });
        panel.add(option3);
        add(panel);
        setVisible(true);
    }

    private ImageIcon getScaledImageIcon(String imagePath, int width, int height) {
        try {
            BufferedImage img = ImageIO.read(getClass().getResource(imagePath));
            ImageIcon icon = new ImageIcon(img.getScaledInstance(width, height, Image.SCALE_SMOOTH));
            return icon;
        } catch (IOException ex) {
            System.err.println("Error loading image: " + imagePath);
            return null;
        }
    }


    }
