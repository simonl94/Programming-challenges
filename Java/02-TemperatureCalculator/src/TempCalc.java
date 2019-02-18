import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.text.DefaultCaret;

public class TempCalc {
    private static String ENTER = "Calculate";
    static JButton enterButton;
    static JCheckBox celsiusButton;
    static JCheckBox farButton;
    public static JTextArea output;
    public static JTextField input;
    static JFrame frame;
    static JPanel panel;
    public static String testString = "test";


    public static void main(String... args)
    {
        try
        {
            UIManager.setLookAndFeel(UIManager.getSystemLookAndFeelClassName());
        }
        catch (Exception ex)
        {
            ex.printStackTrace();
        }
        createFrame();
    }

    public static void createFrame()
    {
        frame = new JFrame("Temperature Calculator");
        frame.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        panel = new JPanel();
        panel.setLayout(new BoxLayout(panel, BoxLayout.Y_AXIS));
        panel.setOpaque(true);
        ButtonListener buttonListener = new ButtonListener();
        output = new JTextArea(15, 50);
        output.setWrapStyleWord(true);
        output.setEditable(false);
        JScrollPane scroller = new JScrollPane(output);
        scroller.setVerticalScrollBarPolicy(ScrollPaneConstants.VERTICAL_SCROLLBAR_ALWAYS);
        scroller.setHorizontalScrollBarPolicy(ScrollPaneConstants.HORIZONTAL_SCROLLBAR_NEVER);
        JPanel inputpanel = new JPanel();
        inputpanel.setLayout(new FlowLayout());
        input = new JTextField(20);
        enterButton = new JButton("Calculate");
        enterButton.setActionCommand(ENTER);
        enterButton.addActionListener(buttonListener);
        // enterButton.setEnabled(false);
        input.setActionCommand(ENTER);
        input.addActionListener(buttonListener);
        DefaultCaret caret = (DefaultCaret) output.getCaret();
        caret.setUpdatePolicy(DefaultCaret.ALWAYS_UPDATE);
        panel.add(scroller);
        JPanel checkPanel = new JPanel(new GridLayout(0, 1));
        inputpanel.add(input);
        inputpanel.add(enterButton);
        checkPanel.add(celsiusButton);
        checkPanel.add(farButton);

        panel.add(inputpanel);
        frame.getContentPane().add(BorderLayout.CENTER, panel);
        frame.pack();
        frame.setLocationByPlatform(true);
        // Center of screen
        // frame.setLocationRelativeTo(null);
        frame.setVisible(true);
        frame.setResizable(false);
        input.requestFocus();
        celsiusButton = new JCheckBox("Celsius");
        celsiusButton.setMnemonic(KeyEvent.VK_C);
        celsiusButton.setSelected(true);

        farButton = new JCheckBox("Fahrenheit");
        farButton.setMnemonic(KeyEvent.VK_F);
        farButton.setSelected(true);

        //Register a listener for the check boxes.
        //celsiusButton.addItemListener(this);
        //farButton.addItemListener(this);
    }

    public static class ButtonListener implements ActionListener
    {

        public void actionPerformed(final ActionEvent ev)
        {
            if (!input.getText().trim().equals(""))
            {
                String cmd = ev.getActionCommand();
                if (ENTER.equals(cmd))
                {
                    output.append(input.getText());
                    if (input.getText().trim().equals(testString)) output.append(" = " + testString);
                    else output.append(" != " + testString);
                    output.append("\n");
                }
            }
            input.setText("");
            input.requestFocus();
        }
    }
}

