using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace VolaGUI_Final
{
    public partial class volaguiForm : Form
    {
        

        public volaguiForm( )
        {
            InitializeComponent();
        }


        public void AddTabs(List<string> commands)
        {
            string configFileLine = "";
            int counter = 1;
            
            StreamReader configFile = null;
            if (File.Exists("volagui.config")) { configFile = new StreamReader("volagui.config"); }
            else { throw new System.InvalidOperationException("Config File is Missing!"); }


            while ((configFileLine = configFile.ReadLine()) != null)
            {
                //mainGUI.imageStatus.Text = configFileLine;
                if (Regex.IsMatch(configFileLine, "^#.*#\\s*$"))
                {
                    if (Regex.IsMatch(configFileLine, "^#*\\s*Imaging\\s*#*\\s*$") ||
                        Regex.IsMatch(configFileLine, "^#*\\s*VolaGUI Settings\\s*#*\\s*$"))
                    {

                    }
                    else
                    {
                        TabPage newTab = new TabPage("tabPage" + counter.ToString());

                        newTab.Location = new System.Drawing.Point(4, 22);
                        newTab.Padding = new System.Windows.Forms.Padding(3);
                        newTab.Size = new System.Drawing.Size(591, 421);
                        newTab.TabIndex = 0;
                        newTab.UseVisualStyleBackColor = true;

                        optionBox newOptionBox = new optionBox();
                        newOptionBox.initiate();
                        newTab.Controls.Add(newOptionBox.optionsGBox);

                        commandBox newCommandBox = new commandBox( );
                        newCommandBox.initiate(commands);
                        newTab.Controls.Add(newCommandBox.commandGBox);


                        executionBox newExecutionBox = new executionBox();
                        newExecutionBox.initiate();
                        newTab.Controls.Add(newExecutionBox.executionGBox);


                        this.ResumeLayout(false);


                        configFileLine = Regex.Replace(configFileLine, "^#*\\s*", "");
                        configFileLine = Regex.Replace(configFileLine, "\\s*#*\\s*$", "");
                        newTab.Text = configFileLine;
                        this.tabControl1.TabPages.Add(newTab);

                        while ((configFileLine = configFile.ReadLine()) != null && !(Regex.IsMatch(configFileLine,"^\\s*$")))
                        {
                            string tmpCommand;
                            if (Regex.IsMatch(configFileLine, "^[\\D\\d]+:[\\D\\d]+:\\D*$"))
                            {
                                tmpCommand = configFileLine.Substring(0, configFileLine.IndexOf(":"));
                                newCommandBox.addDropDownData(tmpCommand);
                                commands.Add(configFileLine);
                            }
                        }

                        counter++;
                        //MessageBox.Show(configFileLine);
                    }
                }//else if(counter > 1 && !(Regex.IsMatch(configFileLine, "^\\s*$")))
                //{
                //    commands.Add(configFileLine);
                //    MessageBox.Show(configFileLine);
                //    this.commandDescription.Text = configFileLine;
                //}
            }
            configFile.Close();
        }
    }


    partial class commandBox
    {
        public void addDropDownData(string command)
        {
            commandSelection.Items.Add(command);
        }
        private void commandSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selection = commandSelection.SelectedItem;
            foreach (string command in this.commands)
            {
                //this.commandDescription.Text = command;   
                if((command.Split(':'))[0] == selection.ToString( ))
                {
                    this.commandDescription.Text = (command.Split(':'))[1];
                }
            }
        }
    }
}
