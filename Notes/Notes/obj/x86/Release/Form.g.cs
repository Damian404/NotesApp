﻿#pragma checksum "C:\Users\Damian Curran\documents\visual studio 2015\Projects\Notes\Notes\Form.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8F691CF1AD39B0B3B88FFB910F144D97"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notes
{
    partial class Form : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class Form_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IForm_Bindings
        {
            private global::Notes.Form dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj2;
            private global::Windows.UI.Xaml.Controls.TextBox obj3;

            private Form_obj1_BindingsTracking bindingsTracking;

            public Form_obj1_Bindings()
            {
                this.bindingsTracking = new Form_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj2).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.NoteHandler.SelectedNote.NoteName = (this.obj2).Text;
                                }
                            };
                        break;
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        (this.obj3).LostFocus += (global::System.Object sender, global::Windows.UI.Xaml.RoutedEventArgs e) =>
                            {
                                if (this.initialized)
                                {
                                    // Update Two Way binding
                                    this.dataRoot.NoteHandler.SelectedNote.NoteDes = (this.obj3).Text;
                                }
                            };
                        break;
                    default:
                        break;
                }
            }

            // IForm_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // Form_obj1_Bindings

            public void SetDataRoot(global::Notes.Form newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Notes.Form obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler(obj.NoteHandler, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler(phase);
                    }
                }
            }
            private void Update_NoteHandler(global::ViewModels.NoteHandlerViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_NoteHandler(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler_SelectedNote(obj.SelectedNote, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote(phase);
                    }
                }
            }
            private void Update_NoteHandler_SelectedNote(global::ViewModels.NoteViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_NoteHandler_SelectedNote(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, phase);
                        this.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote_NoteName(phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_NoteHandler_SelectedNote_NoteDes(phase);
                    }
                }
            }
            private void Update_NoteHandler_SelectedNote_NoteName(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, obj, null);
                }
            }
            private void Update_NoteHandler_SelectedNote_NoteDes(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, obj, null);
                }
            }

            private void UpdateFallback_NoteHandler(int phase)
            {
                this.UpdateFallback_NoteHandler_SelectedNote(phase);
            }

            private void UpdateFallback_NoteHandler_SelectedNote(int phase)
            {
                this.UpdateFallback_NoteHandler_SelectedNote_NoteName(phase);
                this.UpdateFallback_NoteHandler_SelectedNote_NoteDes(phase);
            }

            private void UpdateFallback_NoteHandler_SelectedNote_NoteName(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, "", null);
                }
            }

            private void UpdateFallback_NoteHandler_SelectedNote_NoteDes(int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj3, "", null);
                }
            }

            private class Form_obj1_BindingsTracking
            {
                global::System.WeakReference<Form_obj1_Bindings> WeakRefToBindingObj; 

                public Form_obj1_BindingsTracking(Form_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<Form_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_NoteHandler(null);
                    UpdateChildListeners_NoteHandler_SelectedNote(null);
                }

                public void PropertyChanged_NoteHandler(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Form_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ViewModels.NoteHandlerViewModel obj = sender as global::ViewModels.NoteHandlerViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_NoteHandler_SelectedNote(obj.SelectedNote, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_NoteHandler_SelectedNote(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "SelectedNote":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote(obj.SelectedNote, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::ViewModels.NoteHandlerViewModel cache_NoteHandler = null;
                public void UpdateChildListeners_NoteHandler(global::ViewModels.NoteHandlerViewModel obj)
                {
                    if (obj != cache_NoteHandler)
                    {
                        if (cache_NoteHandler != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_NoteHandler).PropertyChanged -= PropertyChanged_NoteHandler;
                            cache_NoteHandler = null;
                        }
                        if (obj != null)
                        {
                            cache_NoteHandler = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_NoteHandler;
                        }
                    }
                }
                public void PropertyChanged_NoteHandler_SelectedNote(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    Form_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        string propName = e.PropertyName;
                        global::ViewModels.NoteViewModel obj = sender as global::ViewModels.NoteViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                    bindings.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, DATA_CHANGED);
                                    bindings.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_NoteHandler_SelectedNote_NoteName(DATA_CHANGED);
                                bindings.UpdateFallback_NoteHandler_SelectedNote_NoteDes(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "NoteName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote_NoteName(obj.NoteName, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote_NoteName(DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "NoteDes":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_NoteHandler_SelectedNote_NoteDes(obj.NoteDes, DATA_CHANGED);
                                    }
                                    else
                                    {
                                    bindings.UpdateFallback_NoteHandler_SelectedNote_NoteDes(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::ViewModels.NoteViewModel cache_NoteHandler_SelectedNote = null;
                public void UpdateChildListeners_NoteHandler_SelectedNote(global::ViewModels.NoteViewModel obj)
                {
                    if (obj != cache_NoteHandler_SelectedNote)
                    {
                        if (cache_NoteHandler_SelectedNote != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_NoteHandler_SelectedNote).PropertyChanged -= PropertyChanged_NoteHandler_SelectedNote;
                            cache_NoteHandler_SelectedNote = null;
                        }
                        if (obj != null)
                        {
                            cache_NoteHandler_SelectedNote = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_NoteHandler_SelectedNote;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 3:
                {
                    this.des = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Form_obj1_Bindings bindings = new Form_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

