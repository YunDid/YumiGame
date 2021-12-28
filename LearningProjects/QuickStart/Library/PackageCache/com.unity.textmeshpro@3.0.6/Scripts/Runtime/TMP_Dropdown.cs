using System.Collections;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for toggle with history widget.
    /// </summary>
    public class DebugUIHandlerToggleHistory : DebugUIHandlerToggle
    {
        Toggle[] historyToggles;
        const float xDecal = 60f;

        internal override void SetWidget(DebugUI.Widget widget)
        {
            int historyDepth = (widget as DebugUI.HistoryBoolField)?.historyDepth ?? 0;
            historyToggles = new Toggle[historyDepth];
            for (int index = 0; index < historyDepth; ++index)
            {
                var historyToggle = Instantiate(valueToggle, transform);
                Vector3 pos = historyToggle.transform.position;
                pos.x += (index + 1) * xDecal;
                historyToggle.transform.position = pos;
                var background = historyToggle.transform.GetChild(0).GetComponent<Image>();
                background.sprite = Sprite.Create(Texture2D.whiteTexture, new Rect(-1, -1, 2, 2), Vector2.zero);
                background.color = new Color32(50, 50, 50, 120);
                var checkmark = background.transform.GetChild(0).GetComponent<Image>();
                checkmark.color = new Color32(110, 110, 110, 255);
                historyToggles[index] = historyToggle.GetComponent<Toggle>();
            }

            //this call UpdateValueLabel which will rely on historyToggles
            base.SetWidget(widget);
        }

        /// <summary>
        /// Update the label.
        /// </summary>
        internal protected override void UpdateValueLabel()
        {
            base.UpdateValueLabel();
            DebugUI.HistoryBoolField field = m_Field as DebugUI.HistoryBoolField;
            int historyDepth = field?.historyDepth ?? 0;
            for (int index = 0; index < historyDepth; ++index)
            {
                if (index < historyToggles.Length && historyToggles[index] != null)
                    historyToggles[index].isOn = field.GetHistoryValue(index);
            }

            if (isActiveAndEnabled)
                StartCoroutine(RefreshAfterSanitization());
        }

        IEnumerator RefreshAfterSanitization()
        {
            yield return null; //wait one frame
            valueToggle.isOn = m_Field.getter();
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for vertical layoyut widget.
    /// </summary>
    public class DebugUIHandlerVBox : DebugUIHandlerWidget
    {
        DebugUIHandlerContainer m_Container;

        internal override void SetWidget(DebugUI.Widget widget)
        {
            base.SetWidget(widget);
            m_Container = GetComponent<DebugUIHandlerContainer>();
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            if (!fromNext && !m_Container.IsDirectChild(previous))
            {
                var lastItem = m_Container.GetLastItem();
                DebugManager.instance.ChangeSelection(lastItem, false);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Next implementation.
        /// </summary>
        /// <returns>Next widget UI handler, parent if there is none.</returns>
        public override DebugUIHandlerWidget Next()
        {
            if (m_Container == null)
                return base.Next();

            var firstChild = m_Container.GetFirstItem();

            if (firstChild == null)
                return base.Next();

            return firstChild;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for value widgets.
    /// </summary>
    public class DebugUIHandlerValue : DebugUIHandlerWidget
    {
        /// <summary>Name of the value field.</summary>
        public Text nameLabel;
        /// <summary>Value of the value field.</summary>
        public Text valueLabel;
        DebugUI.Value m_Field;

        float m_Timer;

        /// <summary>
        /// OnEnable implementation.
        /// </summary>
        protected override void OnEnable()
        {
            m_Timer = 0f;
        }

        internal override void SetWidget(DebugUI.Widget widget)
        {
            base.SetWidget(widget);
            m_Field = CastWidget<DebugUI.Value>();
            nameLabel.text = m_Field.displayName;
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            nameLabel.color = colorSelected;
            valueLabel.color = colorSelected;
            return true;
        }

        /// <summary>
        /// OnDeselection implementation.
        /// </summary>
        public override void OnDeselection()
        {
            nameLabel.color = colorDefault;
            valueLabel.color = colorDefault;
        }

        void Update()
        {
            if (m_Timer >= m_Field.refreshRate)
            {
                valueLabel.text = m_Field.GetValue().ToString();
                m_Timer -= m_Field.refreshRate;
            }

            m_Timer += Time.deltaTime;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for vector3 widget.
    /// </summary>
    public class DebugUIHandlerVector3 : DebugUIHandlerWidget
    {
        /// <summary>Name of the Vector3 field.</summary>
        public Text nameLabel;
        /// <summary>Value of the Vector3 toggle.</summary>
        public UIFoldout valueToggle;

        /// <summary>X float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldX;
        /// <summary>Y float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldY;
        /// <summary>Z float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldZ;

        DebugUI.Vector3Field m_Field;
        DebugUIHandlerContainer m_Container;

        internal override void SetWidget(DebugUI.Widget widget)
        {
            base.SetWidget(widget);
            m_Field = CastWidget<DebugUI.Vector3Field>();
            m_Container = GetComponent<DebugUIHandlerContainer>();
            nameLabel.text = m_Field.displayName;

            fieldX.getter = () => m_Field.GetValue().x;
            fieldX.setter = v => SetValue(v, x: true);
            fieldX.nextUIHandler = fieldY;
            SetupSettings(fieldX);

            fieldY.getter = () => m_Field.GetValue().y;
            fieldY.setter = v => SetValue(v, y: true);
            fieldY.previousUIHandler = fieldX;
            fieldY.nextUIHandler = fieldZ;
            SetupSettings(fieldY);

            fieldZ.getter = () => m_Field.GetValue().z;
            fieldZ.setter = v => SetValue(v, z: true);
            fieldZ.previousUIHandler = fieldY;
            SetupSettings(fieldZ);
        }

        void SetValue(float v, bool x = false, bool y = false, bool z = false)
        {
            var vec = m_Field.GetValue();
            if (x) vec.x = v;
            if (y) vec.y = v;
            if (z) vec.z = v;
            m_Field.SetValue(vec);
        }

        void SetupSettings(DebugUIHandlerIndirectFloatField field)
        {
            field.parentUIHandler = this;
            field.incStepGetter = () => m_Field.incStep;
            field.incStepMultGetter = () => m_Field.incStepMult;
            field.decimalsGetter = () => m_Field.decimals;
            field.Init();
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            if (fromNext || valueToggle.isOn == false)
            {
                nameLabel.color = colorSelected;
            }
            else if (valueToggle.isOn)
            {
                if (m_Container.IsDirectChild(previous))
                {
                    nameLabel.color = colorSelected;
                }
                else
                {
                    var lastItem = m_Container.GetLastItem();
                    DebugManager.instance.ChangeSelection(lastItem, false);
                }
            }

            return true;
        }

        /// <summary>
        /// OnDeselection implementation.
        /// </summary>
        public override void OnDeselection()
        {
            nameLabel.color = colorDefault;
        }

        /// <summary>
        /// OnIncrement implementation.
        /// </summary>
        /// <param name="fast">True if incrementing fast.</param>
        public override void OnIncrement(bool fast)
        {
            valueToggle.isOn = true;
        }

        /// <summary>
        /// OnDecrement implementation.
        /// </summary>
        /// <param name="fast">Trye if decrementing fast.</param>
        public override void OnDecrement(bool fast)
        {
            valueToggle.isOn = false;
        }

        /// <summary>
        /// OnAction implementation.
        /// </summary>
        public override void OnAction()
        {
            valueToggle.isOn = !valueToggle.isOn;
        }

        /// <summary>
        /// Next implementation.
        /// </summary>
        /// <returns>Next widget UI handler, parent if there is none.</returns>
        public override DebugUIHandlerWidget Next()
        {
            if (!valueToggle.isOn || m_Container == null)
                return base.Next();

            var firstChild = m_Container.GetFirstItem();

            if (firstChild == null)
                return base.Next();

            return firstChild;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for vector2 widgets.
    /// </summary>
    public class DebugUIHandlerVector2 : DebugUIHandlerWidget
    {
        /// <summary>Name of the Vector2 field.</summary>
        public Text nameLabel;
        /// <summary>Value of the Vector2 toggle.</summary>
        public UIFoldout valueToggle;

        /// <summary>X float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldX;
        /// <summary>Y float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldY;

        DebugUI.Vector2Field m_Field;
        DebugUIHandlerContainer m_Container;

        internal override void SetWidget(DebugUI.Widget widget)
        {
            base.SetWidget(widget);
            m_Field = CastWidget<DebugUI.Vector2Field>();
            m_Container = GetComponent<DebugUIHandlerContainer>();
            nameLabel.text = m_Field.displayName;

            fieldX.getter = () => m_Field.GetValue().x;
            fieldX.setter = x => SetValue(x, x: true);
            fieldX.nextUIHandler = fieldY;
            SetupSettings(fieldX);

            fieldY.getter = () => m_Field.GetValue().y;
            fieldY.setter = x => SetValue(x, y: true);
            fieldY.previousUIHandler = fieldX;
            SetupSettings(fieldY);
        }

        void SetValue(float v, bool x = false, bool y = false)
        {
            var vec = m_Field.GetValue();
            if (x) vec.x = v;
            if (y) vec.y = v;
            m_Field.SetValue(vec);
        }

        void SetupSettings(DebugUIHandlerIndirectFloatField field)
        {
            field.parentUIHandler = this;
            field.incStepGetter = () => m_Field.incStep;
            field.incStepMultGetter = () => m_Field.incStepMult;
            field.decimalsGetter = () => m_Field.decimals;
            field.Init();
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            if (fromNext || valueToggle.isOn == false)
            {
                nameLabel.color = colorSelected;
            }
            else if (valueToggle.isOn)
            {
                if (m_Container.IsDirectChild(previous))
                {
                    nameLabel.color = colorSelected;
                }
                else
                {
                    var lastItem = m_Container.GetLastItem();
                    DebugManager.instance.ChangeSelection(lastItem, false);
                }
            }

            return true;
        }

        /// <summary>
        /// OnDeselection implementation.
        /// </summary>
        public override void OnDeselection()
        {
            nameLabel.color = colorDefault;
        }

        /// <summary>
        /// OnIncrement implementation.
        /// </summary>
        /// <param name="fast">True if incrementing fast.</param>
        public override void OnIncrement(bool fast)
        {
            valueToggle.isOn = true;
        }

        /// <summary>
        /// OnDecrement implementation.
        /// </summary>
        /// <param name="fast">Trye if decrementing fast.</param>
        public override void OnDecrement(bool fast)
        {
            valueToggle.isOn = false;
        }

        /// <summary>
        /// OnAction implementation.
        /// </summary>
        public override void OnAction()
        {
            valueToggle.isOn = !valueToggle.isOn;
        }

        /// <summary>
        /// Next implementation.
        /// </summary>
        /// <returns>Next widget UI handler, parent if there is none.</returns>
        public override DebugUIHandlerWidget Next()
        {
            if (!valueToggle.isOn || m_Container == null)
                return base.Next();

            var firstChild = m_Container.GetFirstItem();

            if (firstChild == null)
                return base.Next();

            return firstChild;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// DebugUIHandler for vector4 widget.
    /// </summary>
    public class DebugUIHandlerVector4 : DebugUIHandlerWidget
    {
        /// <summary>Name of the Vector4 field.</summary>
        public Text nameLabel;
        /// <summary>Value of the Vector4 toggle.</summary>
        public UIFoldout valueToggle;

        /// <summary>X float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldX;
        /// <summary>Y float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldY;
        /// <summary>Z float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldZ;
        /// <summary>W float field.</summary>
        public DebugUIHandlerIndirectFloatField fieldW;

        DebugUI.Vector4Field m_Field;
        DebugUIHandlerContainer m_Container;

        internal override void SetWidget(DebugUI.Widget widget)
        {
            base.SetWidget(widget);
            m_Field = CastWidget<DebugUI.Vector4Field>();
            m_Container = GetComponent<DebugUIHandlerContainer>();
            nameLabel.text = m_Field.displayName;

            fieldX.getter = () => m_Field.GetValue().x;
            fieldX.setter = x => SetValue(x, x: true);
            fieldX.nextUIHandler = fieldY;
            SetupSettings(fieldX);

            fieldY.getter = () => m_Field.GetValue().y;
            fieldY.setter = x => SetValue(x, y: true);
            fieldY.previousUIHandler = fieldX;
            fieldY.nextUIHandler = fieldZ;
            SetupSettings(fieldY);

            fieldZ.getter = () => m_Field.GetValue().z;
            fieldZ.setter = x => SetValue(x, z: true);
            fieldZ.previousUIHandler = fieldY;
            fieldZ.nextUIHandler = fieldW;
            SetupSettings(fieldZ);

            fieldW.getter = () => m_Field.GetValue().w;
            fieldW.setter = x => SetValue(x, w: true);
            fieldW.previousUIHandler = fieldZ;
            SetupSettings(fieldW);
        }

        void SetValue(float v, bool x = false, bool y = false, bool z = false, bool w = false)
        {
            var vec = m_Field.GetValue();
            if (x) vec.x = v;
            if (y) vec.y = v;
            if (z) vec.z = v;
            if (w) vec.w = v;
            m_Field.SetValue(vec);
        }

        void SetupSettings(DebugUIHandlerIndirectFloatField field)
        {
            field.parentUIHandler = this;
            field.incStepGetter = () => m_Field.incStep;
            field.incStepMultGetter = () => m_Field.incStepMult;
            field.decimalsGetter = () => m_Field.decimals;
            field.Init();
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            if (fromNext || valueToggle.isOn == false)
            {
                nameLabel.color = colorSelected;
            }
            else if (valueToggle.isOn)
            {
                if (m_Container.IsDirectChild(previous))
                {
                    nameLabel.color = colorSelected;
                }
                else
                {
                    var lastItem = m_Container.GetLastItem();
                    DebugManager.instance.ChangeSelection(lastItem, false);
                }
            }

            return true;
        }

        /// <summary>
        /// OnDeselection implementation.
        /// </summary>
        public override void OnDeselection()
        {
            nameLabel.color = colorDefault;
        }

        /// <summary>
        /// OnIncrement implementation.
        /// </summary>
        /// <param name="fast">True if incrementing fast.</param>
        public override void OnIncrement(bool fast)
        {
            valueToggle.isOn = true;
        }

        /// <summary>
        /// OnDecrement implementation.
        /// </summary>
        /// <param name="fast">Trye if decrementing fast.</param>
        public override void OnDecrement(bool fast)
        {
            valueToggle.isOn = false;
        }

        /// <summary>
        /// OnAction implementation.
        /// </summary>
        public override void OnAction()
        {
            valueToggle.isOn = !valueToggle.isOn;
        }

        /// <summary>
        /// Next implementation.
        /// </summary>
        /// <returns>Next widget UI handler, parent if there is none.</returns>
        public override DebugUIHandlerWidget Next()
        {
            if (!valueToggle.isOn || m_Container == null)
                return base.Next();

            var firstChild = m_Container.GetFirstItem();

            if (firstChild == null)
                return base.Next();

            return firstChild;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      using System;

namespace UnityEngine.Rendering.UI
{
    /// <summary>
    /// Base class for handling UI actions for widgets.
    /// </summary>
    public class DebugUIHandlerWidget : MonoBehaviour
    {
        /// <summary>
        /// Default widget color.
        /// </summary>
        [HideInInspector]
        public Color colorDefault = new Color(0.8f, 0.8f, 0.8f, 1f);

        /// <summary>
        /// Selected widget color.
        /// </summary>
        [HideInInspector]
        public Color colorSelected = new Color(0.25f, 0.65f, 0.8f, 1f);

        /// <summary>
        /// Parent widget UI Handler.
        /// </summary>
        public DebugUIHandlerWidget parentUIHandler { get; set; }
        /// <summary>
        /// Previous widget UI Handler.
        /// </summary>
        public DebugUIHandlerWidget previousUIHandler { get; set; }
        /// <summary>
        /// Next widget UI Handler.
        /// </summary>
        public DebugUIHandlerWidget nextUIHandler { get; set; }

        /// <summary>
        /// Associated widget.
        /// </summary>
        protected DebugUI.Widget m_Widget;

        /// <summary>
        /// OnEnable implementation.
        /// </summary>
        protected virtual void OnEnable() {}

        internal virtual void SetWidget(DebugUI.Widget widget)
        {
            m_Widget = widget;
        }

        internal DebugUI.Widget GetWidget()
        {
            return m_Widget;
        }

        /// <summary>
        /// Casts the widget to the correct type.
        /// </summary>
        /// <typeparam name="T">Type of the widget.</typeparam>
        /// <returns>Properly cast reference to the widget.</returns>
        protected T CastWidget<T>()
            where T : DebugUI.Widget
        {
            var casted = m_Widget as T;
            string typeName = m_Widget == null ? "null" : m_Widget.GetType().ToString();

            if (casted == null)
                throw new InvalidOperationException("Can't cast " + typeName + " to " + typeof(T));

            return casted;
        }

        /// <summary>
        /// OnSelection implementation.
        /// </summary>
        /// <param name="fromNext">True if the selection wrapped around.</param>
        /// <param name="previous">Previous widget.</param>
        /// <returns>True if the selection is allowed.</returns>
        public virtual bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
        {
            return true;
        }

        /// <summary>
        /// OnDeselection implementation.
        /// </summary>
        public virtual void OnDeselection() {}

        /// <summary>
        /// OnAction implementation.
        /// </summary>
        public virtual void OnAction() {}

        /// <summary>
        /// OnIncrement implementation.
        /// </summary>
        /// <param name="fast">True if incrementing fast.</param>
        public virtual void OnIncrement(bool fast) {}

        /// <summary>
        /// OnDecrement implementation.
        /// </summary>
        /// <param name="fast">Trye if decrementing fast.</param>
        public virtual void OnDecrement(bool fast) {}

        /// <summary>
        /// Previous implementation.
        /// </summary>
        /// <returns>Previous widget UI handler, parent if there is none.</returns>
        public virtual DebugUIHandlerWidget Previous()
        {
            if (previousUIHandler != null)
                return previousUIHandler;

            if (parentUIHandler != null)
                return parentUIHandler;

            return null;
        }

        /// <summary>
        /// Next implementation.
        /// </summary>
        /// <returns>Next widget UI handler, parent if there is none.</returns>
        public virtual DebugUIHandlerWidget Next()
        {
            if (nextUIHandler != null)
                return nextUIHandler;

            if (parentUIHandler != null)
            {
                var p = parentUIHandler;
                while (p != null)
                {
                    var n = p.nextUIHandler;

                    if (n != null)
                        return n;

                    p = p.parentUIHandler;
                }
            }

            return null;
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 INDX( 	 m�#           (   8   �           �                                   
�N�k�� �d��M����/��n��k��        �              D E 9 5 B 9 ~ 1 . C S                    DN�k�� �d��M����/��n��k��                     D E B 2 3 1 ~ 1 . C S                    DN�k�� �d��M����/��n��k��                     D E B 2 3 1 ~ 1 . C S               h X          DN�k�� �d��M����/��n��k��                     D E B 2 3 1 ~ 1 . C S               h X         DN�k�� �d��M����/��n��k��                     D E