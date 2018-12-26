
Public Class Form1

    Dim path As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoginForm1.ShowDialog()

        FolderBrowserDialog1.Description = "Choose the path to your pictures!"
        FolderBrowserDialog1.ShowDialog()

        path = FolderBrowserDialog1.SelectedPath.Replace("\", "\\")


        Strategy_Attack_Label.Enabled = False
        Strategy_Attack_Value_Label.Enabled = False
        Strategy_Defense_Label.Enabled = False
        Strategy_Defense_Value_Label.Enabled = False
        Strategy_TrackBar.Enabled = False
        Light_Level_Label.Enabled = False
        Light_Level_NumericUpDown.Enabled = False
        Script_Name_Label.Enabled = False
        Script_Name_TextBox.Enabled = False
        Flags_Panel.Visible = False
        Skill_NumericUpDown.Enabled = False
        Skill_Attack_Label.Enabled = False
        Skill_Attack_NumericUpDown.Enabled = False
        RuneSpell_Name_TextBox.Visible = False
        Defense_Radius_NumericUpDown.Enabled = False
        Defense_Duration_Label.Enabled = False
        Defense_Duration_NumericUpDown.Enabled = False
        Defense_Speed_Change_Label.Enabled = False
        Defense_Speed_Change_NumericUpDown.Enabled = False
        Loot_Name_TextBox.Enabled = False
        Loot_CountMax_NumericUpDown.Enabled = False
        Loot_SubType_ComboBox.Enabled = False
        Loot_ActionId_NumericUpDown.Enabled = False
        Loot_UniqueId_NumericUpDown.Enabled = False
        Loot_Text_TextBox.Enabled = False
        LookType_CheckBox.Checked = True
        Loot_Hint_Label.Hide()
        IO_Save_Monster_Button.Enabled = False

        If (LookType_CheckBox.Checked = True) Then
            If System.IO.File.Exists(path + "\\addons\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif") Then

                Outfit_PictureBox.Image = Image.FromFile(path + "\\addons\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif")
            Else
                Outfit_PictureBox.ImageLocation = path + "\\none.png"

            End If
        End If

        If (LookTypeEx_CheckBox.Checked = True) Then
            If System.IO.File.Exists(path + "\\items\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif") Then

                Outfit_PictureBox.Image = Image.FromFile(path + "\\items\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif")
            Else
                Outfit_PictureBox.ImageLocation = path + "\\none.png"

            End If
        End If

        If System.IO.File.Exists(path + "\\mounts\\" + Convert.ToString(Mount_NumericUpDown.Value) + ".gif") Then

            Mount_PictureBox.Image = Image.FromFile(path + "\\mounts\\" + Convert.ToString(Mount_NumericUpDown.Value) + ".gif")
        Else
            Mount_PictureBox.ImageLocation = path + "\\none.png"

        End If

       If System.IO.File.Exists(path + "\\shoot effect\\" + Shoot_Effect_ComboBox.Text + ".gif") Then

            Shoot_Effect_PictureBox.Image = Image.FromFile(path + "\\shoot effect\\" + Shoot_Effect_ComboBox.Text + ".gif")
        Else
            Shoot_Effect_PictureBox.ImageLocation = path + "\\none.png"
        End If

        If System.IO.File.Exists(path + "\\area effect\\" + Area_Effect_ComboBox.Text + ".gif") Then

            Area_Effect_PictureBox.Image = Image.FromFile(path + "\\area effect\\" + Area_Effect_ComboBox.Text + ".gif")
        Else
            Area_Effect_PictureBox.ImageLocation = path + "\\none.png"

        End If

        If System.IO.File.Exists(path + "\\area effect\\" + Defense_AreaEffect_ComboBox.Text + ".gif") Then

            Defense_Area_Effect_PictureBox.Image = Image.FromFile(path + "\\area effect\\" + Defense_AreaEffect_ComboBox.Text + ".gif")
        Else
            Defense_Area_Effect_PictureBox.ImageLocation = path + "\\none.png"
        End If

    End Sub
    Private Sub XdToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Flags_Menu.Click

        Flags_Panel.Visible = True
        Script_Panel.Visible = False

    End Sub

    Private Sub Strategy_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Strategy_CheckBox.CheckedChanged
        If (Strategy_CheckBox.Checked = True) Then
            Strategy_Attack_Label.Enabled = True
            Strategy_Attack_Value_Label.Enabled = True
            Strategy_Defense_Label.Enabled = True
            Strategy_Defense_Value_Label.Enabled = True
            Strategy_TrackBar.Enabled = True
        Else
            Strategy_Attack_Label.Enabled = False
            Strategy_Attack_Value_Label.Enabled = False
            Strategy_Defense_Label.Enabled = False
            Strategy_Defense_Value_Label.Enabled = False
            Strategy_TrackBar.Enabled = False
        End If
    End Sub

    Private Sub Strategy_TrackBar_Scroll(sender As Object, e As EventArgs) Handles Strategy_TrackBar.Scroll
        Dim strategy_values_of_attack As Integer = Strategy_TrackBar.Value

        Strategy_Attack_Value_Label.Text = strategy_values_of_attack
        Strategy_Defense_Value_Label.Text = 100 - strategy_values_of_attack


    End Sub

    Private Sub Monster_Menu_Click(sender As Object, e As EventArgs) Handles Monster_Menu.Click
        Flags_Panel.Visible = False
    End Sub

    Private Sub Light_Color_NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Light_Color_NumericUpDown.ValueChanged
        If (Light_Color_NumericUpDown.Value > 0) Then

            Light_Level_Label.Enabled = True
            Light_Level_NumericUpDown.Enabled = True
        Else
            Light_Level_Label.Enabled = False
            Light_Level_NumericUpDown.Enabled = False

        End If

    End Sub

    Private Sub Script_Menu_Click(sender As Object, e As EventArgs) Handles Script_Menu.Click

        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Attacks_Panel.Visible = False

    End Sub

    Private Sub Script_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Script_CheckBox.CheckedChanged
        If (Script_CheckBox.Checked = True) Then
            Script_Name_Label.Enabled = True
            Script_Name_TextBox.Enabled = True
        Else
            Script_Name_Label.Enabled = False
            Script_Name_TextBox.Enabled = False

        End If
    End Sub

    Private Sub Attacks_Menu_Click(sender As Object, e As EventArgs) Handles Attacks_Menu.Click
        Script_Panel.Visible = True
        Attacks_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = False
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LookType_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LookType_CheckBox.CheckedChanged
        If (LookType_CheckBox.Checked = True) Then
            LookTypeEx_CheckBox.Checked = False

        End If
    End Sub

    Private Sub LookTypeEx_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LookTypeEx_CheckBox.CheckedChanged
        If (LookTypeEx_CheckBox.Checked = True) Then
            LookType_CheckBox.Checked = False

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Delete_Button.Click
        Attack_Table_RichTextBox.Clear()


    End Sub

    Private Sub Radius_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Radius_CheckBox.CheckedChanged
        If (Radius_CheckBox.Checked = True) Then
            Length_CheckBox.Enabled = False
            Damage_Length_NumericUpDown.Enabled = False
            Spread_CheckBox.Enabled = False
            Damage_Spread_NumericUpDown.Enabled = False
        Else
            Length_CheckBox.Enabled = True
            Damage_Length_NumericUpDown.Enabled = True
            Spread_CheckBox.Enabled = True
            Damage_Spread_NumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub Length_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Length_CheckBox.CheckedChanged
        If (Length_CheckBox.Checked = True Or Spread_CheckBox.Checked = True) Then
            Radius_CheckBox.Enabled = False
            Damage_Radius_NumericUpDown.Enabled = False
        Else
            Radius_CheckBox.Enabled = True
            Damage_Radius_NumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub Spread_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Spread_CheckBox.CheckedChanged
        If (Spread_CheckBox.Checked = True Or Length_CheckBox.Checked = True) Then
            Radius_CheckBox.Enabled = False
            Damage_Radius_NumericUpDown.Enabled = False
        Else
            Radius_CheckBox.Enabled = True
            Damage_Radius_NumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles Skill_NumericUpDown.ValueChanged

    End Sub

    Private Sub NumericUpDown3_ValueChanged_1(sender As Object, e As EventArgs) Handles Skill_Attack_NumericUpDown.ValueChanged

    End Sub

    Private Sub Attack_Skill_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Attack_Skill_CheckBox.CheckedChanged
        If (Attack_Skill_CheckBox.Checked = True) Then
            Skill_Attack_Label.Enabled = True
            Skill_Attack_NumericUpDown.Enabled = True
            Skill_NumericUpDown.Enabled = True

            Damage_Max_NumericUpDown.Enabled = False
            Damage_Min_NumericUpDown.Enabled = False
            Damage_Min_Label.Enabled = False
            Damage_Max_Label.Enabled = False
        Else
            Skill_Attack_Label.Enabled = False
            Skill_Attack_NumericUpDown.Enabled = False
            Skill_NumericUpDown.Enabled = False

            Damage_Max_NumericUpDown.Enabled = True
            Damage_Min_NumericUpDown.Enabled = True
            Damage_Min_Label.Enabled = True
            Damage_Max_Label.Enabled = True

        End If
    End Sub

    Private Sub Attack_Name_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Attack_Name_ComboBox.SelectedIndexChanged
        If (Not Attack_Name_ComboBox.SelectedItem = "melee") Then
            If (Attack_Skill_CheckBox.Checked = True) Then
                Attack_Skill_CheckBox.CheckState = False

            End If
            Skill_Attack_Label.Hide()
            Attack_Skill_CheckBox.Hide()
            Skill_Attack_NumericUpDown.Hide()
            Skill_NumericUpDown.Hide()
            Attack_Type_Label.Show()
            Attack_Type_ComboBox.Show()
        Else
            Attack_Type_Label.Hide()
            Attack_Type_ComboBox.Hide()
            Skill_Attack_Label.Show()
            Attack_Skill_CheckBox.Show()
            Skill_Attack_NumericUpDown.Show()
            Skill_NumericUpDown.Show()

        End If

        If (Attack_Name_ComboBox.SelectedItem = "elemental") Then
            Attack_Type_ComboBox.Items.Clear()
            Dim elemental = {"physical", "energy", "earth", "fire", "lifedrain", "manadrain", "healing", "drown", "ice", "holy", "death"}

            Dim i As Integer = 0
            For Each elem In elemental
                Attack_Type_ComboBox.Items.Insert(i, elem)
                i += 1
            Next

            Attack_Type_ComboBox.SelectedIndex = 0
        End If

        If (Attack_Name_ComboBox.SelectedItem = "conditions") Then
            Attack_Type_ComboBox.Items.Clear()
            Dim conditions = {"physicalcondition", "energycondition", "earthcondition", "firecondition", "drowncondition", "icecondition", "holycondition", "deathcondition"}

            Dim i As Integer = 0
            For Each cond In conditions
                Attack_Type_ComboBox.Items.Insert(i, cond)
                i += 1
            Next

            Attack_Type_ComboBox.SelectedIndex = 0
        End If


        If (Attack_Name_ComboBox.SelectedItem = "fields") Then
            Attack_Type_ComboBox.Items.Clear()
            Dim fields = {"firefield", "poisonfield", "energyfield"}

            Dim i As Integer = 0
            For Each fiel In fields
                Attack_Type_ComboBox.Items.Insert(i, fiel)
                i += 1
            Next

            Attack_Type_ComboBox.SelectedIndex = 0
        End If

        If (Attack_Name_ComboBox.SelectedItem = "runes/spells") Then
            Attack_Type_ComboBox.Items.Clear()
            Attack_Type_Label.Text = "Runes/Spells Name:"
            Attack_Type_ComboBox.Visible = False
            RuneSpell_Name_TextBox.Visible = True
        Else
            Attack_Type_Label.Text = "Type:"
            RuneSpell_Name_TextBox.Visible = False
        End If
    End Sub


    Private Sub Add_Button_Click(sender As Object, e As EventArgs) Handles Add_Button.Click

        Dim atck As String = ""

        atck += "        <attack name="""

        If (Attack_Name_ComboBox.SelectedItem = "melee") Then
            atck += "melee" + """"
        End If

        If (Attack_Name_ComboBox.SelectedItem = "elemental" Or Attack_Name_ComboBox.SelectedItem = "conditions" Or Attack_Name_ComboBox.SelectedItem = "fields") Then
            atck += Attack_Type_ComboBox.Text + """"
        End If

        If (Attack_Name_ComboBox.SelectedItem = "runes/spells") Then
            atck += RuneSpell_Name_TextBox.Text + """"
        End If

        atck += " interval=""" + Convert.ToString(Damage_Interval_NumericUpDown.Value) + """ chance=""" + Convert.ToString(Damage_Chance_NumericUpDown.Value) + """ "


        If (Length_CheckBox.Checked = True) Then
            atck += "length=""" + Convert.ToString(Damage_Length_NumericUpDown.Value) + """ "
        End If

        If (Spread_CheckBox.Checked = True) Then
            atck += "spread=""" + Convert.ToString(Damage_Spread_NumericUpDown.Value) + """ "
        End If

        If (Radius_CheckBox.Checked = True) Then
            atck += "radius=""" + Convert.ToString(Damage_Radius_NumericUpDown.Value) + """ "
        End If

        If (Poison_CheckBox.Checked = True) Then
            atck += "poison=""" + Convert.ToString(Damage_Poison_NumericUpDown.Value) + """ "
        End If

        If (Target_CheckBox.Checked = True) Then
            atck += "target=""1" + """ "
        End If

        If (Range_NumericUpDown.Value > 0) Then
            atck += "range=""" + Convert.ToString(Range_NumericUpDown.Value) + """ "
        End If

        If (Attack_Skill_CheckBox.Checked = True) Then
            atck += " skill=""" + Convert.ToString(Skill_NumericUpDown.Value) + """ attack=""" + Convert.ToString(Skill_Attack_NumericUpDown.Value) + """"
        Else
            atck += " min=""" + Convert.ToString(Damage_Min_NumericUpDown.Value) + """ max=""" + Convert.ToString(Damage_Max_NumericUpDown.Value) + """"
        End If


        If (Area_Effect_CheckBox.Checked = True Or Shoot_Effect_CheckBox.Checked = True) Then
            atck += ">"

            If (Area_Effect_CheckBox.Checked = True) Then
                atck += Environment.NewLine + "            <attribute key=""areaEffect"" value=""" + Area_Effect_ComboBox.Text + """/>"
            End If

            If (Shoot_Effect_CheckBox.Checked = True) Then
                atck += Environment.NewLine + "            <attribute key=""shootEffect"" value=""" + Shoot_Effect_ComboBox.Text + """/>"
            End If
            atck += Environment.NewLine + "        </attack>"
        Else
            atck += "/>"
        End If


        Attack_Table_RichTextBox.Text += atck + Environment.NewLine


    End Sub

    Private Sub Attack_Table_RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles Attack_Table_RichTextBox.TextChanged

    End Sub

    Private Sub Defenses_Menu_Click(sender As Object, e As EventArgs) Handles Defenses_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = False

    End Sub

    Private Sub Defense_Name_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Defense_Name_ComboBox.SelectedIndexChanged
        If (Not Defense_Name_ComboBox.SelectedItem = "healing") Then

            If (Defense_Radius_CheckBox.Checked = True) Then
                Defense_Radius_CheckBox.CheckState = False
            End If

            Defense_Healing_GroupBox.Enabled = False
        Else
            Defense_Healing_GroupBox.Enabled = True
        End If

        If (Defense_Name_ComboBox.SelectedItem = "speed" Or Defense_Name_ComboBox.SelectedItem = "invisible") Then
            Defense_Duration_Label.Enabled = True
            Defense_Duration_NumericUpDown.Enabled = True
        Else
            Defense_Duration_Label.Enabled = False
            Defense_Duration_NumericUpDown.Enabled = False
        End If

        If (Defense_Name_ComboBox.SelectedItem = "speed") Then
            Defense_Speed_Change_Label.Enabled = True
            Defense_Speed_Change_NumericUpDown.Enabled = True
        Else
            Defense_Speed_Change_Label.Enabled = False
            Defense_Speed_Change_NumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub Defense_Radius_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Defense_Radius_CheckBox.CheckedChanged
        If (Defense_Radius_CheckBox.Checked = True) Then
            Defense_Radius_NumericUpDown.Enabled = True
        Else
            Defense_Radius_NumericUpDown.Enabled = False

        End If
    End Sub

    Private Sub Defenses_Delete_Button_Click(sender As Object, e As EventArgs) Handles Defenses_Delete_Button.Click
        Defenses_RichTextBox.Clear()

    End Sub

    Private Sub Defenses_Add_Button_Click(sender As Object, e As EventArgs) Handles Defenses_Add_Button.Click
        Dim defense As String = ""

        defense = defense + "        <defense name=""" + Defense_Name_ComboBox.Text + """ interval=""" + Convert.ToString(Defense_Interval_NumericUpDown.Value) + """ chance=""" + Convert.ToString(Defense_Chance_NumericUpDown.Value) + """ "

        If (Defense_Name_ComboBox.SelectedItem = "healing") Then
            defense = defense + "min=""" + Convert.ToString(Defense_Min_NumericUpDown.Value) + """ max=""" + Convert.ToString(Defense_Max_NumericUpDown.Value) + """"
        End If

        If (Defense_Radius_CheckBox.Checked = True) Then
            defense = defense + "radius=""" + Convert.ToString(Defense_Radius_NumericUpDown.Value) + """"
        End If

        If (Defense_Name_ComboBox.SelectedItem = "speed") Then
            defense = defense + "duration=""" + Convert.ToString(Defense_Duration_NumericUpDown.Value) + """ speedchange=""" + Convert.ToString(Defense_Speed_Change_NumericUpDown.Value) + """"
        End If

        If (Defense_Name_ComboBox.SelectedItem = "invisible") Then
            defense = defense + "duration=""" + Convert.ToString(Defense_Duration_NumericUpDown.Value) + """"
        End If

        defense = defense + ">" + Environment.NewLine + "            <attribute key=""areaEffect"" value=""" + Defense_AreaEffect_ComboBox.Text + """/>" + Environment.NewLine + "        </defense>"





        Defenses_RichTextBox.Text += defense + Environment.NewLine
    End Sub

    Private Sub Elements_Menu_Click(sender As Object, e As EventArgs) Handles Elements_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = False
    End Sub

    Private Sub Immunities_Menu_Click(sender As Object, e As EventArgs) Handles Immunities_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = True
        Summons_Panel.Visible = False

    End Sub

    Private Sub Summons_Menu_Click(sender As Object, e As EventArgs) Handles Summons_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = True
        Summons_Panel.Visible = True
        Voices_Panel.Visible = False

    End Sub

    Private Sub Summon_Delete_Button_Click(sender As Object, e As EventArgs) Handles Summon_Delete_Button.Click
        Summons_RichTextBox.Clear()

    End Sub

    Private Sub Summon_Add_Button_Click(sender As Object, e As EventArgs) Handles Summon_Add_Button.Click
        Dim summon As String = ""

        summon = summon + "        <summon name=""" + Summon_Name_TextBox.Text + """ interval=""" + Convert.ToString(Summon_Interval_NumericUpDown.Value) + """ chance=""" + Convert.ToString(Summon_Chance_NumericUpDown.Value) + """ max=""" + Convert.ToString(Summon_Max_NumericUpDown.Value) + """/>"


        Summons_RichTextBox.Text += summon + Environment.NewLine
    End Sub

    Private Sub Voices_Menu_Click(sender As Object, e As EventArgs) Handles Voices_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = True
        Summons_Panel.Visible = True
        Voices_Panel.Visible = True
        Loot_Panel.Visible = False

    End Sub

    Private Sub Voice_Delete_Button_Click(sender As Object, e As EventArgs) Handles Voice_Delete_Button.Click
        Voices_RichTextBox.Clear()

    End Sub

    Private Sub Voice_Add_Button_Click(sender As Object, e As EventArgs) Handles Voice_Add_Button.Click
        Dim voice As String = ""

        voice = voice + "        <voice sentence=""" + Voice_Sentence_TextBox.Text + """"

        If (Voice_Yell_CheckBox.Checked = True) Then
            voice = voice + " yell=""1"""
        End If

        voice = voice + "/>"


        Voices_RichTextBox.Text += voice + Environment.NewLine
    End Sub

    Private Sub Loot_Menu_Click(sender As Object, e As EventArgs) Handles Loot_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = True
        Summons_Panel.Visible = True
        Voices_Panel.Visible = True
        Loot_Panel.Visible = True
        IO_Panel.Visible = False


    End Sub

    Private Sub Loot_Delete_Button_Click(sender As Object, e As EventArgs) Handles Loot_Delete_Button.Click
        Loot_RichTextBox.Clear()

    End Sub

    Private Sub Loot_Add_Button_Click(sender As Object, e As EventArgs) Handles Loot_Add_Button.Click

        Dim loot As String = ""
        Dim subtypenum = {1, 2, 3, 4, 5, 6, 7, 10, 11, 13, 14, 15, 19, 21, 26, 27, 28, 35, 43}


        If (Loot_Inside_Bag_CheckBox.Checked = True) Then
            loot = loot + "            "
        End If

        loot = loot + "        <item "
        If (Loot_Name_CheckBox.Checked = True) Then
            loot = loot + "name=""" + Loot_Name_TextBox.Text + """ "
        Else
            loot = loot + "id=""" + Convert.ToString(Loot_Item_ID_NumericUpDown.Value) + """ "
        End If

        If (Loot_CountMax_CheckBox.Checked = True) Then
            loot = loot + "countmax=""" + Convert.ToString(Loot_CountMax_NumericUpDown.Value) + """ "
        End If

        If (Loot_SubType_CheckBox.Checked = True) Then

            For i As Integer = 0 To 18

                If (Loot_SubType_ComboBox.SelectedIndex = i) Then
                    loot = loot + "subtype=""" + Convert.ToString(subtypenum(i)) + """ "
                End If
            Next
        End If

        If (Loot_ActionId_CheckBox.Checked = True) Then
            loot = loot + "actionId=""" + Convert.ToString(Loot_ActionId_NumericUpDown.Value) + """ "
        End If

        If (Loot_UniqueId_CheckBox.Checked = True) Then
            loot = loot + "uniqueId=""" + Convert.ToString(Loot_UniqueId_NumericUpDown.Value) + """ "
        End If

        If (Loot_Text_CheckBox.Checked = True) Then
            loot = loot + "text=""" + Loot_Text_TextBox.Text + """ "
        End If

        loot = loot + "chance=""" + Convert.ToString(Loot_Chance_NumericUpDown.Value) + """/>"

        Loot_RichTextBox.Text += loot + Environment.NewLine
    End Sub


    Private Sub Loot_Name_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_Name_CheckBox.CheckedChanged
        If (Loot_Name_CheckBox.Checked = True) Then
            Loot_Name_TextBox.Enabled = True
            Loot_Item_ID_Label.Enabled = False
            Loot_Item_ID_NumericUpDown.Enabled = False
        Else
            Loot_Item_ID_Label.Enabled = True
            Loot_Item_ID_NumericUpDown.Enabled = True
            Loot_Name_TextBox.Enabled = False
        End If
    End Sub

    Private Sub Loot_CountMax_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_CountMax_CheckBox.CheckedChanged
        If (Loot_CountMax_CheckBox.Checked = True) Then
            Loot_CountMax_NumericUpDown.Enabled = True
        Else
            Loot_CountMax_NumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub Loot_SubType_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_SubType_CheckBox.CheckedChanged
        If (Loot_SubType_CheckBox.Checked = True) Then
            Loot_SubType_ComboBox.Enabled = True
        Else
            Loot_SubType_ComboBox.Enabled = False

        End If
    End Sub

    Private Sub Loot_ActionId_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_ActionId_CheckBox.CheckedChanged
        If (Loot_ActionId_CheckBox.Checked = True) Then
            Loot_ActionId_NumericUpDown.Enabled = True
        Else
            Loot_ActionId_NumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub Loot_UniqueId_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_UniqueId_CheckBox.CheckedChanged
        If (Loot_UniqueId_CheckBox.Checked = True) Then
            Loot_UniqueId_NumericUpDown.Enabled = True
        Else
            Loot_UniqueId_NumericUpDown.Enabled = False
        End If
    End Sub

    Private Sub Loot_Text_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_Text_CheckBox.CheckedChanged
        If (Loot_Text_CheckBox.Checked = True) Then
            Loot_Text_TextBox.Enabled = True
        Else
            Loot_Text_TextBox.Enabled = False
        End If
    End Sub

    Private Sub Loot_Inside_Bag_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_Inside_Bag_CheckBox.CheckedChanged
        If (Loot_Inside_Bag_CheckBox.Checked = True) Then

            Loot_Hint_Label.Show()

            Loot_RichTextBox.Text += "        <item"
            If (Not Loot_Inside_Name_CheckBox.Checked = True) Then
                Loot_RichTextBox.Text += " id=""" + Convert.ToString(Loot_Inside_BagId_NumericUpDown.Value) + """ "
            Else
                Loot_RichTextBox.Text += " name=""" + Loot_Inside_Name_TextBox.Text + """ "
            End If
            Loot_RichTextBox.Text += "chance=""100000"">" + Environment.NewLine + "            <inside>" + Environment.NewLine
        Else
            Loot_Hint_Label.Hide()

            Loot_RichTextBox.Text += "            </inside>" + Environment.NewLine
        End If
    End Sub

    Private Sub Loot_Inside_Name_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Loot_Inside_Name_CheckBox.CheckedChanged
        If (Loot_Inside_Name_CheckBox.Checked = True) Then
            Loot_Inside_Bag_Id_Label.Enabled = False
            Loot_Inside_BagId_NumericUpDown.Enabled = False
        Else
            Loot_Inside_Bag_Id_Label.Enabled = True
            Loot_Inside_BagId_NumericUpDown.Enabled = True
        End If
    End Sub

    Private Sub IO_Menu_Click(sender As Object, e As EventArgs) Handles IO_Menu.Click
        Attacks_Panel.Visible = True
        Script_Panel.Visible = True
        Flags_Panel.Visible = True
        Defenses_Panel.Visible = True
        Elements_Panel.Visible = True
        Immunities_Panel.Visible = True
        Summons_Panel.Visible = True
        Voices_Panel.Visible = True
        Loot_Panel.Visible = True
        IO_Panel.Visible = True
    End Sub

    Private Sub IO_Save_Button_Click(sender As Object, e As EventArgs) Handles IO_Save_Button.Click

        Dim m As String = ""

        m += "<?xml version=""1.0"" encoding=""UTF-8""?>" + Environment.NewLine

        m += "<monster name=""" + Monster_Name_TextBox.Text + """ nameDescription=""" + Monster_Description_TextBox.Text + """ race=""" + Race_ComboBox.Text + """ experience=""" + Experience_TextBox.Text + """ skull=""" + Skull_ComboBox.Text + """ speed=""" + Speed_TextBox.Text + """ manacost=""" + Mana_Cost_TextBox.Text + """>" + Environment.NewLine

        m += "    <health now=""" + Health_Now_TextBox.Text + """ max=""" + Health_Max_TextBox.Text + """/>" + Environment.NewLine

        m += "    <look "
        If (LookTypeEx_CheckBox.Checked = True) Then
            m += "typeEx="""
        Else
            m += "type="""
        End If
        m += Convert.ToString(LookType_NumericUpDown.Value) + """ head=""" + Convert.ToString(Head_NumericUpDown.Value) + """ body=""" + Convert.ToString(Body_NumericUpDown.Value) + """ legs=""" + Convert.ToString(Legs_NumericUpDown.Value) + """ feet=""" + Convert.ToString(Feet_NumericUpDown.Value) + """ addons=""" + Convert.ToString(Addons_NumericUpDown.Value) + """ mount=""" + Convert.ToString(Mount_NumericUpDown.Value) + """ corpse=""" + Corpse_TextBox.Text + """/>" + Environment.NewLine

        m += "    <targetchange interval=""" + Interval_TextBox.Text + """ chance=""" + Chance_TextBox.Text + """/>" + Environment.NewLine

        If (Strategy_CheckBox.Checked = True) Then
            m += "    <strategy attack=""" + Strategy_Attack_Value_Label.Text + """ defense=""" + Strategy_Defense_Value_Label.Text + """/>" + Environment.NewLine
        End If

        m += "    <flags>" + Environment.NewLine

        Dim flags = {Summonable_CheckBox, Attackable_CheckBox, Hostile_CheckBox, Illusionable_CheckBox, Convinceable_CheckBox, Pushable_CheckBox, CanPushItems_CheckBox, CanPushCreatures_CheckBox, Hide_Health_CheckBox}

        For Each fl In flags

            m += "        <flag "

            If (fl.Checked = True) Then

                m += fl.Text + "=""1"""
            Else
                m += fl.Text + "=""0"""

            End If
            m += "/>" + Environment.NewLine
        Next

        m += "        <flag targetdistance=""" + Convert.ToString(Target_Distance_NumericUpDown.Value) + """/>" + Environment.NewLine

        m += "        <flag staticattack=""" + Static_Attack_Value_Label.Text + """/>" + Environment.NewLine

        m += "        <flag lightcolor=""" + Convert.ToString(Light_Color_NumericUpDown.Value) + """/>" + Environment.NewLine
        m += "        <flag lightlevel=""" + Convert.ToString(Light_Level_NumericUpDown.Value) + """/>" + Environment.NewLine

        m += "        <flag runonhealth=""" + Run_On_Health_Value_Label.Text + """/>" + Environment.NewLine + "    </flags>" + Environment.NewLine

        If (Script_CheckBox.Checked = True) Then
            m += "    <script>" + Environment.NewLine + "        <event name=""" + Script_Name_TextBox.Text + """/>" + Environment.NewLine + "    </script>" + Environment.NewLine
        End If

        If (Attack_Table_RichTextBox.Text <> String.Empty) Then
            m += "    <attacks>" + Environment.NewLine + Attack_Table_RichTextBox.Text + "    </attacks>" + Environment.NewLine

        End If

        m += "    <defenses armor=""" + Convert.ToString(Defense_Armor_NumericUpDown.Value) + """ defense=""" + Convert.ToString(Defense_Defense_NumericUpDown.Value) + """"
        If (Defenses_RichTextBox.Text <> String.Empty) Then
            m += ">"
        Else
            m += "/>"
        End If

        m += Environment.NewLine + Defenses_RichTextBox.Text

        If (Defenses_RichTextBox.Text <> String.Empty) Then
            m += "    </defenses>"
        End If

        Dim elem = {Element_Holy_NumericUpDown, Element_Ice_NumericUpDown, Element_Death_NumericUpDown, Element_Fire_NumericUpDown, Element_Earth_NumericUpDown, Element_Energy_NumericUpDown, Element_Physical_NumericUpDown, Element_Life_Drain_NumericUpDown, Element_Drown_NumericUpDown}

        m += "    <elements>" + Environment.NewLine

        For Each vale In elem

            If (vale.Value <> 0) Then

                m += "        <element "

                Select Case vale.TabIndex
                    Case Is = Element_Holy_NumericUpDown.TabIndex
                        m += "holy"

                    Case Element_Ice_NumericUpDown.TabIndex
                        m += "ice"

                    Case Element_Death_NumericUpDown.TabIndex
                        m += "death"

                    Case Element_Fire_NumericUpDown.TabIndex
                        m += "fire"

                    Case Element_Earth_NumericUpDown.TabIndex
                        m += "earth"

                    Case Element_Energy_NumericUpDown.TabIndex
                        m += "energy"

                    Case Element_Physical_NumericUpDown.TabIndex
                        m += "physical"

                    Case Element_Life_Drain_NumericUpDown.TabIndex
                        m += "lifedrain"

                    Case Element_Drown_NumericUpDown.TabIndex
                        m += "drown"
                End Select

                m += "Percent=""" + Convert.ToString(vale.Value) + """/>" + Environment.NewLine
            End If
        Next

        m += "    </elements>" + Environment.NewLine + "    <immunities>" + Environment.NewLine

        Dim immunes = {Immunitie_Holy_CheckBox, Immunitie_Fire_CheckBox, Immunitie_Ice_CheckBox, Immunitie_Death_CheckBox, Immunitie_Energy_CheckBox, Immunitie_Earth_CheckBox, Immunitie_Physical_CheckBox, Immunitie_Life_Drain_CheckBox, Immunitie_Drown_CheckBox, Immunitie_Paralyze_CheckBox, Immunitie_Drunk_CheckBox, Immunitie_Invisible_CheckBox, Immunitie_Outfit_CheckBox}

        For Each imm In immunes
            If (imm.Checked = True) Then

                m += "        <immunity " + imm.Text.ToLower + "=""1""/>" + Environment.NewLine

            End If
        Next

        m += "    </immunities>" + Environment.NewLine

        If (Summons_RichTextBox.Text <> String.Empty) Then

            m += "    <summons maxSummons=""" + Convert.ToString(Summon_Max_Summons_NumericUpDown.Value) + """>" + Environment.NewLine + Summons_RichTextBox.Text + "    </summons>" + Environment.NewLine

        End If

        If (Voices_RichTextBox.Text <> String.Empty) Then

            m += "    <voices interval=""" + Convert.ToString(Voice_Interval_NumericUpDown.Value) + """ chance=""" + Convert.ToString(Voice_Chance_NumericUpDown.Value) + """>" + Environment.NewLine + Voices_RichTextBox.Text + "    </voices>" + Environment.NewLine

        End If

        If (Loot_RichTextBox.Text <> String.Empty) Then

            m += "    <loot>" + Environment.NewLine + Loot_RichTextBox.Text + "    </loot>" + Environment.NewLine

        End If

        m += "</monster>"
        IO_RichTextBox.Text = m
    End Sub


    Private Sub Static_Attack_TrackBar_Scroll(sender As Object, e As EventArgs) Handles Static_Attack_TrackBar.Scroll
        Static_Attack_Value_Label.Text = Static_Attack_TrackBar.Value
    End Sub

    Private Sub Run_On_Health_TrackBar_Scroll(sender As Object, e As EventArgs) Handles Run_On_Health_TrackBar.Scroll
        Run_On_Health_Value_Label.Text = Run_On_Health_TrackBar.Value
    End Sub

    Private Sub LookType_NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles LookType_NumericUpDown.ValueChanged


        If (LookType_CheckBox.Checked = True) Then
            If System.IO.File.Exists(path + "\\addons\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif") Then

                Outfit_PictureBox.Image = Image.FromFile(path + "\\addons\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif")
            Else
                Outfit_PictureBox.ImageLocation = path + "\\none.png"

            End If
        End If

        If (LookTypeEx_CheckBox.Checked = True) Then
            If System.IO.File.Exists(path + "\\items\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif") Then

                Outfit_PictureBox.Image = Image.FromFile(path + "\\items\\" + Convert.ToString(LookType_NumericUpDown.Value) + ".gif")
            Else
                Outfit_PictureBox.ImageLocation = path + "\\none.png"

            End If
        End If
    End Sub



    Private Sub Skull_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Skull_ComboBox.SelectedIndexChanged
        If System.IO.File.Exists(path + "\\skulls\\" + Skull_ComboBox.Text + ".png") Then

            Monster_Skull_PictureBox.Image = Image.FromFile(path + "\\skulls\\" + Skull_ComboBox.Text + ".png")

        End If
    End Sub

    Private Sub Mount_NumericUpDown_ValueChanged(sender As Object, e As EventArgs) Handles Mount_NumericUpDown.ValueChanged

        If System.IO.File.Exists(path + "\\mounts\\" + Convert.ToString(Mount_NumericUpDown.Value) + ".gif") Then

            Mount_PictureBox.Image = Image.FromFile(path + "\\mounts\\" + Convert.ToString(Mount_NumericUpDown.Value) + ".gif")
        Else
            Mount_PictureBox.ImageLocation = path + "\\none.png"

        End If

    End Sub

    

    Private Sub Area_Effect_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Area_Effect_ComboBox.SelectedIndexChanged
        If System.IO.File.Exists(path + "\\area effect\\" + Area_Effect_ComboBox.Text + ".gif") Then

            Area_Effect_PictureBox.Image = Image.FromFile(path + "\\area effect\\" + Area_Effect_ComboBox.Text + ".gif")
        Else
            Area_Effect_PictureBox.ImageLocation = path + "\\none.png"

        End If
    End Sub

    Private Sub Shoot_Effect_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Shoot_Effect_ComboBox.SelectedIndexChanged

        If System.IO.File.Exists(path + "\\shoot effect\\" + Shoot_Effect_ComboBox.Text + ".gif") Then

            Shoot_Effect_PictureBox.Image = Image.FromFile(path + "\\shoot effect\\" + Shoot_Effect_ComboBox.Text + ".gif")
        Else
            Shoot_Effect_PictureBox.ImageLocation = path + "\\none.png"
        End If
    End Sub



    Private Sub Defense_AreaEffect_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Defense_AreaEffect_ComboBox.SelectedIndexChanged

        If System.IO.File.Exists(path + "\\area effect\\" + Defense_AreaEffect_ComboBox.Text + ".gif") Then

            Defense_Area_Effect_PictureBox.Image = Image.FromFile(path + "\\area effect\\" + Defense_AreaEffect_ComboBox.Text + ".gif")
        Else
            Defense_Area_Effect_PictureBox.ImageLocation = path + "\\none.png"
        End If

    End Sub

    Private Sub IO_Save_Monster_Button_Click(sender As Object, e As EventArgs) Handles IO_Save_Monster_Button.Click

        If IO_File_Name_TextBox.Text.Length > 0 Then

            SaveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"
            SaveFileDialog1.FileName = IO_File_Name_TextBox.Text
            SaveFileDialog1.ShowDialog()
            System.IO.File.WriteAllText(SaveFileDialog1.FileName, IO_RichTextBox.Text)
            IO_XML_TextBox.Text = "<monster name=""" + Monster_Name_TextBox.Text + """ file=""" + IO_File_Name_TextBox.Text + ".xml""/>"

        Else
            MsgBox("Put the file name!")
        End If

    End Sub

    Private Sub IO_RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles IO_RichTextBox.TextChanged
        If (IO_RichTextBox.Text <> String.Empty) Then
            IO_Save_Monster_Button.Enabled = True
        End If

    End Sub

End Class
