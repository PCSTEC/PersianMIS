using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telerik.WinControls.UI;

namespace PersianMIS.ManageProcess
{
    public class PersianDiagramRibbonBarLocalizationProvider : DiagramRibbonBarLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                //case DiagramRibbonBarStringId.DiagramRibbonBarHomeTab:
                //    return "خانه";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonOpen:
                //    return "باز کردن";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonCopy:
                //    return "کپی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonConnectorTool:
                //    return "ابزار ارتباطی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonCut:
                //    return "برداشت";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonDelete:
                //    return "حذف";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonDragging:
                //    return "درگ کردن";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonExportToImage:
                //    return "خروجی تصویری";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonLayout:
                //    return "لایه بندی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonNew:
                //    return "جدید";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonPaste:
                //    return "چسباندن";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonPointerTool:
                //    return "انتخاب";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonPrint:
                //    return "چاپ";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonRedo:
                //    return "تکرار مرحله";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonResizing:
                //    return "تغییر ابعاد";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonRotation:
                //    return "چرخش";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonSave:
                //    return "ذخیره";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonSendBackward:
                //    return "ارسال به رو";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonSendToBack:
                //    return "ارسال به پشت";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonShowGrid:
                //    return "نمایش جدول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonTextTool:
                //    return "ابزار متن";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonUndo:
                //    return "برگشت به عقب";
                //case DiagramRibbonBarStringId.DiagramRibbonBarClipboardGroup:
                //    return "حافظه موقت";
                //case DiagramRibbonBarStringId.DiagramRibbonBarColorGroup:
                //    return "رنگ";
                //case DiagramRibbonBarStringId.DiagramRibbonBarGapModeGroup:
                //    return "حالت فاصله مابین";
                //case DiagramRibbonBarStringId.DiagramRibbonBarGeneralGroup:
                //    return "عمومی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarGridGroup:
                //    return "جدول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLabelCellHeight:
                //    return "عرض سلول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLabelCellWidth:
                //    return "طول سلول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLabelSnapX:
                //    return "پرش محور x";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLabelSnapY:
                //    return "پرش محور y";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLabelZoom:
                //    return "بزرگ نمایی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarLayoutGroup:
                //    return "گروه";

                //case DiagramRibbonBarStringId.DiagramRibbonBarPrintGroup:
                //    return "چاپ";
                //case DiagramRibbonBarStringId.DiagramRibbonBarPropertiesGroup:
                //    return "تنظیمات";
                //case DiagramRibbonBarStringId.DiagramRibbonBarSelectionModeGroup:
                //    return "نحوه انتخاب ";
                //case DiagramRibbonBarStringId.DiagramRibbonBarSettingsTab:
                //    return "تنظیمات";
                //case DiagramRibbonBarStringId.DiagramRibbonBarToolsGroup:
                //    return "ابزار";
                //case DiagramRibbonBarStringId.DiagramRibbonBarZoomGroup:
                //    return "بزرگ نمایی";

                //case DiagramRibbonBarStringId.DiagramRibbonLabelBackground:
                //    return "برچسب زمینه";
                //case DiagramRibbonBarStringId.DiagramRibbonLabelGridColor:
                //    return "رنگ جدول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonSnapToGrid:
                //    return "تنظیم بر اساس جدول";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonSnapToItems:
                //    return "تنظیم بر اساس محتوی";
                //case DiagramRibbonBarStringId.DiagramRibbonBarArrangementGroup:
                //    return "مرتب سازی ";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonBringForward:
                //    return "جابجایی به جلو";
                //case DiagramRibbonBarStringId.DiagramRibbonBarButtonBringToTop:
                //    return "جابجایی به بالا";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}