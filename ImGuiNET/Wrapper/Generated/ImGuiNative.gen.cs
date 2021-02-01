using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        #if UNITY_IOS && !UNITY_EDITOR
        private const string dll_name = "__Internal";
        #else
        private const string dll_name = "cimgui";
        #endif
        
        [DllImport(dll_name)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport(dll_name)]
        public static extern void igAlignTextToFramePadding();
        [DllImport(dll_name)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport(dll_name)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginChild(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginChildID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginDragDropTarget();
        [DllImport(dll_name)]
        public static extern void igBeginGroup();
        [DllImport(dll_name)]
        public static extern byte igBeginMainMenuBar();
        [DllImport(dll_name)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport(dll_name)]
        public static extern byte igBeginMenuBar();
        [DllImport(dll_name)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(dll_name)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(dll_name)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiMouseButton mouse_button, byte also_over_items);
        [DllImport(dll_name)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport(dll_name)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport(dll_name)]
        public static extern void igBeginTooltip();
        [DllImport(dll_name)]
        public static extern void igBullet();
        [DllImport(dll_name)]
        public static extern void igBulletText(byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport(dll_name)]
        public static extern float igCalcItemWidth();
        [DllImport(dll_name)]
        public static extern void igCalcListClipping(int items_count, float items_height, int* out_items_display_start, int* out_items_display_end);
        [DllImport(dll_name, EntryPoint = "igCalcTextSize_nonUDT2")]
        public static extern Vector2 igCalcTextSize(byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport(dll_name)]
        public static extern void igCaptureKeyboardFromApp(byte want_capture_keyboard_value);
        [DllImport(dll_name)]
        public static extern void igCaptureMouseFromApp(byte want_capture_mouse_value);
        [DllImport(dll_name)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport(dll_name)]
        public static extern byte igCheckboxFlags(byte* label, uint* flags, uint flags_value);
        [DllImport(dll_name)]
        public static extern void igCloseCurrentPopup();
        [DllImport(dll_name)]
        public static extern byte igCollapsingHeader(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(dll_name)]
        public static extern byte igCollapsingHeaderBoolPtr(byte* label, byte* p_open, ImGuiTreeNodeFlags flags);
        [DllImport(dll_name)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport(dll_name)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport(dll_name)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport(dll_name)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igColorConvertU32ToFloat4_nonUDT2")]
        public static extern Vector4 igColorConvertU32ToFloat4(uint @in);
        [DllImport(dll_name)]
        public static extern byte igColorEdit3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(dll_name)]
        public static extern byte igColorEdit4(byte* label, Vector4* col, ImGuiColorEditFlags flags);
        [DllImport(dll_name)]
        public static extern byte igColorPicker3(byte* label, Vector3* col, ImGuiColorEditFlags flags);
        [DllImport(dll_name)]
        public static extern byte igColorPicker4(byte* label, Vector4* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport(dll_name)]
        public static extern void igColumns(int count, byte* id, byte border);
        [DllImport(dll_name)]
        public static extern byte igCombo(byte* label, int* current_item, byte** items, int items_count, int popup_max_height_in_items);
        [DllImport(dll_name)]
        public static extern byte igComboStr(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport(dll_name)]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport(dll_name)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport(dll_name)]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport(dll_name)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igDragFloat2(byte* label, Vector2* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igDragFloat3(byte* label, Vector3* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igDragFloat4(byte* label, Vector4* v, float v_speed, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, float power);
        [DllImport(dll_name)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max);
        [DllImport(dll_name)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern void igDummy(Vector2 size);
        [DllImport(dll_name)]
        public static extern void igEnd();
        [DllImport(dll_name)]
        public static extern void igEndChild();
        [DllImport(dll_name)]
        public static extern void igEndChildFrame();
        [DllImport(dll_name)]
        public static extern void igEndCombo();
        [DllImport(dll_name)]
        public static extern void igEndDragDropSource();
        [DllImport(dll_name)]
        public static extern void igEndDragDropTarget();
        [DllImport(dll_name)]
        public static extern void igEndFrame();
        [DllImport(dll_name)]
        public static extern void igEndGroup();
        [DllImport(dll_name)]
        public static extern void igEndMainMenuBar();
        [DllImport(dll_name)]
        public static extern void igEndMenu();
        [DllImport(dll_name)]
        public static extern void igEndMenuBar();
        [DllImport(dll_name)]
        public static extern void igEndPopup();
        [DllImport(dll_name)]
        public static extern void igEndTabBar();
        [DllImport(dll_name)]
        public static extern void igEndTabItem();
        [DllImport(dll_name)]
        public static extern void igEndTooltip();
        [DllImport(dll_name)]
        public static extern ImDrawList* igGetBackgroundDrawList();
        [DllImport(dll_name)]
        public static extern byte* igGetClipboardText();
        [DllImport(dll_name)]
        public static extern uint igGetColorU32(ImGuiCol idx, float alpha_mul);
        [DllImport(dll_name)]
        public static extern uint igGetColorU32Vec4(Vector4 col);
        [DllImport(dll_name)]
        public static extern uint igGetColorU32U32(uint col);
        [DllImport(dll_name)]
        public static extern int igGetColumnIndex();
        [DllImport(dll_name)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport(dll_name)]
        public static extern int igGetColumnsCount();
        [DllImport(dll_name)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetContentRegionAvail_nonUDT2")]
        public static extern Vector2 igGetContentRegionAvail();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetContentRegionMax_nonUDT2")]
        public static extern Vector2 igGetContentRegionMax();
        [DllImport(dll_name)]
        public static extern IntPtr igGetCurrentContext();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetCursorPos_nonUDT2")]
        public static extern Vector2 igGetCursorPos();
        [DllImport(dll_name)]
        public static extern float igGetCursorPosX();
        [DllImport(dll_name)]
        public static extern float igGetCursorPosY();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetCursorScreenPos_nonUDT2")]
        public static extern Vector2 igGetCursorScreenPos();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetCursorStartPos_nonUDT2")]
        public static extern Vector2 igGetCursorStartPos();
        [DllImport(dll_name)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [DllImport(dll_name)]
        public static extern ImDrawData* igGetDrawData();
        [DllImport(dll_name)]
        public static extern IntPtr igGetDrawListSharedData();
        [DllImport(dll_name)]
        public static extern ImFont* igGetFont();
        [DllImport(dll_name)]
        public static extern float igGetFontSize();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetFontTexUvWhitePixel_nonUDT2")]
        public static extern Vector2 igGetFontTexUvWhitePixel();
        [DllImport(dll_name)]
        public static extern ImDrawList* igGetForegroundDrawList();
        [DllImport(dll_name)]
        public static extern int igGetFrameCount();
        [DllImport(dll_name)]
        public static extern float igGetFrameHeight();
        [DllImport(dll_name)]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport(dll_name)]
        public static extern uint igGetIDStr(byte* str_id);
        [DllImport(dll_name)]
        public static extern uint igGetIDRange(byte* str_id_begin, byte* str_id_end);
        [DllImport(dll_name)]
        public static extern uint igGetIDPtr(void* ptr_id);
        [DllImport(dll_name)]
        public static extern ImGuiIO* igGetIO();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetItemRectMax_nonUDT2")]
        public static extern Vector2 igGetItemRectMax();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetItemRectMin_nonUDT2")]
        public static extern Vector2 igGetItemRectMin();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetItemRectSize_nonUDT2")]
        public static extern Vector2 igGetItemRectSize();
        [DllImport(dll_name)]
        public static extern int igGetKeyIndex(ImGuiKey imgui_key);
        [DllImport(dll_name)]
        public static extern int igGetKeyPressedAmount(int key_index, float repeat_delay, float rate);
        [DllImport(dll_name)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetMouseDragDelta_nonUDT2")]
        public static extern Vector2 igGetMouseDragDelta(ImGuiMouseButton button, float lock_threshold);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetMousePos_nonUDT2")]
        public static extern Vector2 igGetMousePos();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetMousePosOnOpeningCurrentPopup_nonUDT2")]
        public static extern Vector2 igGetMousePosOnOpeningCurrentPopup();
        [DllImport(dll_name)]
        public static extern float igGetScrollMaxX();
        [DllImport(dll_name)]
        public static extern float igGetScrollMaxY();
        [DllImport(dll_name)]
        public static extern float igGetScrollX();
        [DllImport(dll_name)]
        public static extern float igGetScrollY();
        [DllImport(dll_name)]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport(dll_name)]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport(dll_name)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport(dll_name)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport(dll_name)]
        public static extern float igGetTextLineHeight();
        [DllImport(dll_name)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport(dll_name)]
        public static extern double igGetTime();
        [DllImport(dll_name)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport(dll_name)]
        public static extern byte* igGetVersion();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetWindowContentRegionMax_nonUDT2")]
        public static extern Vector2 igGetWindowContentRegionMax();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetWindowContentRegionMin_nonUDT2")]
        public static extern Vector2 igGetWindowContentRegionMin();
        [DllImport(dll_name)]
        public static extern float igGetWindowContentRegionWidth();
        [DllImport(dll_name)]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport(dll_name)]
        public static extern float igGetWindowHeight();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetWindowPos_nonUDT2")]
        public static extern Vector2 igGetWindowPos();
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "igGetWindowSize_nonUDT2")]
        public static extern Vector2 igGetWindowSize();
        [DllImport(dll_name)]
        public static extern float igGetWindowWidth();
        [DllImport(dll_name)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport(dll_name)]
        public static extern byte igImageButton(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, int frame_padding, Vector4 bg_col, Vector4 tint_col);
        [DllImport(dll_name)]
        public static extern void igIndent(float indent_w);
        [DllImport(dll_name)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputFloat2(byte* label, Vector2* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputFloat3(byte* label, Vector3* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputFloat4(byte* label, Vector4* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport(dll_name)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(dll_name)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(dll_name)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport(dll_name)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size);
        [DllImport(dll_name)]
        public static extern byte igIsAnyItemActive();
        [DllImport(dll_name)]
        public static extern byte igIsAnyItemFocused();
        [DllImport(dll_name)]
        public static extern byte igIsAnyItemHovered();
        [DllImport(dll_name)]
        public static extern byte igIsAnyMouseDown();
        [DllImport(dll_name)]
        public static extern byte igIsItemActivated();
        [DllImport(dll_name)]
        public static extern byte igIsItemActive();
        [DllImport(dll_name)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport(dll_name)]
        public static extern byte igIsItemDeactivated();
        [DllImport(dll_name)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [DllImport(dll_name)]
        public static extern byte igIsItemEdited();
        [DllImport(dll_name)]
        public static extern byte igIsItemFocused();
        [DllImport(dll_name)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport(dll_name)]
        public static extern byte igIsItemToggledOpen();
        [DllImport(dll_name)]
        public static extern byte igIsItemVisible();
        [DllImport(dll_name)]
        public static extern byte igIsKeyDown(int user_key_index);
        [DllImport(dll_name)]
        public static extern byte igIsKeyPressed(int user_key_index, byte repeat);
        [DllImport(dll_name)]
        public static extern byte igIsKeyReleased(int user_key_index);
        [DllImport(dll_name)]
        public static extern byte igIsMouseClicked(ImGuiMouseButton button, byte repeat);
        [DllImport(dll_name)]
        public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport(dll_name)]
        public static extern byte igIsMouseDown(ImGuiMouseButton button);
        [DllImport(dll_name)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport(dll_name)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport(dll_name)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport(dll_name)]
        public static extern byte igIsMouseReleased(ImGuiMouseButton button);
        [DllImport(dll_name)]
        public static extern byte igIsPopupOpen(byte* str_id);
        [DllImport(dll_name)]
        public static extern byte igIsRectVisible(Vector2 size);
        [DllImport(dll_name)]
        public static extern byte igIsRectVisibleVec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport(dll_name)]
        public static extern byte igIsWindowAppearing();
        [DllImport(dll_name)]
        public static extern byte igIsWindowCollapsed();
        [DllImport(dll_name)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport(dll_name)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport(dll_name)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igListBoxStr_arr(byte* label, int* current_item, byte** items, int items_count, int height_in_items);
        [DllImport(dll_name)]
        public static extern void igListBoxFooter();
        [DllImport(dll_name)]
        public static extern byte igListBoxHeaderVec2(byte* label, Vector2 size);
        [DllImport(dll_name)]
        public static extern byte igListBoxHeaderInt(byte* label, int items_count, int height_in_items);
        [DllImport(dll_name)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport(dll_name)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport(dll_name)]
        public static extern void igLogButtons();
        [DllImport(dll_name)]
        public static extern void igLogFinish();
        [DllImport(dll_name)]
        public static extern void igLogText(byte* fmt);
        [DllImport(dll_name)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [DllImport(dll_name)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [DllImport(dll_name)]
        public static extern void igLogToTTY(int auto_open_depth);
        [DllImport(dll_name)]
        public static extern void* igMemAlloc(uint size);
        [DllImport(dll_name)]
        public static extern void igMemFree(void* ptr);
        [DllImport(dll_name)]
        public static extern byte igMenuItemBool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport(dll_name)]
        public static extern byte igMenuItemBoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport(dll_name)]
        public static extern void igNewFrame();
        [DllImport(dll_name)]
        public static extern void igNewLine();
        [DllImport(dll_name)]
        public static extern void igNextColumn();
        [DllImport(dll_name)]
        public static extern void igOpenPopup(byte* str_id);
        [DllImport(dll_name)]
        public static extern byte igOpenPopupOnItemClick(byte* str_id, ImGuiMouseButton mouse_button);
        [DllImport(dll_name)]
        public static extern void igPlotHistogramFloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(dll_name)]
        public static extern void igPlotLines(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport(dll_name)]
        public static extern void igPopAllowKeyboardFocus();
        [DllImport(dll_name)]
        public static extern void igPopButtonRepeat();
        [DllImport(dll_name)]
        public static extern void igPopClipRect();
        [DllImport(dll_name)]
        public static extern void igPopFont();
        [DllImport(dll_name)]
        public static extern void igPopID();
        [DllImport(dll_name)]
        public static extern void igPopItemWidth();
        [DllImport(dll_name)]
        public static extern void igPopStyleColor(int count);
        [DllImport(dll_name)]
        public static extern void igPopStyleVar(int count);
        [DllImport(dll_name)]
        public static extern void igPopTextWrapPos();
        [DllImport(dll_name)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport(dll_name)]
        public static extern void igPushAllowKeyboardFocus(byte allow_keyboard_focus);
        [DllImport(dll_name)]
        public static extern void igPushButtonRepeat(byte repeat);
        [DllImport(dll_name)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(dll_name)]
        public static extern void igPushFont(ImFont* font);
        [DllImport(dll_name)]
        public static extern void igPushIDStr(byte* str_id);
        [DllImport(dll_name)]
        public static extern void igPushIDRange(byte* str_id_begin, byte* str_id_end);
        [DllImport(dll_name)]
        public static extern void igPushIDPtr(void* ptr_id);
        [DllImport(dll_name)]
        public static extern void igPushIDInt(int int_id);
        [DllImport(dll_name)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport(dll_name)]
        public static extern void igPushStyleColorU32(ImGuiCol idx, uint col);
        [DllImport(dll_name)]
        public static extern void igPushStyleColor(ImGuiCol idx, Vector4 col);
        [DllImport(dll_name)]
        public static extern void igPushStyleVarFloat(ImGuiStyleVar idx, float val);
        [DllImport(dll_name)]
        public static extern void igPushStyleVarVec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport(dll_name)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [DllImport(dll_name)]
        public static extern byte igRadioButtonBool(byte* label, byte active);
        [DllImport(dll_name)]
        public static extern byte igRadioButtonIntPtr(byte* label, int* v, int v_button);
        [DllImport(dll_name)]
        public static extern void igRender();
        [DllImport(dll_name)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport(dll_name)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [DllImport(dll_name)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport(dll_name)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport(dll_name)]
        public static extern byte igSelectable(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(dll_name)]
        public static extern byte igSelectableBoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport(dll_name)]
        public static extern void igSeparator();
        [DllImport(dll_name)]
        public static extern void igSetClipboardText(byte* text);
        [DllImport(dll_name)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport(dll_name)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport(dll_name)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport(dll_name)]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport(dll_name)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport(dll_name)]
        public static extern void igSetCursorPosX(float local_x);
        [DllImport(dll_name)]
        public static extern void igSetCursorPosY(float local_y);
        [DllImport(dll_name)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport(dll_name)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetItemAllowOverlap();
        [DllImport(dll_name)]
        public static extern void igSetItemDefaultFocus();
        [DllImport(dll_name)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [DllImport(dll_name)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport(dll_name)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetNextItemWidth(float item_width);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowFocus();
        [DllImport(dll_name)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport(dll_name)]
        public static extern void igSetScrollFromPosX(float local_x, float center_x_ratio);
        [DllImport(dll_name)]
        public static extern void igSetScrollFromPosY(float local_y, float center_y_ratio);
        [DllImport(dll_name)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [DllImport(dll_name)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [DllImport(dll_name)]
        public static extern void igSetScrollX(float scroll_x);
        [DllImport(dll_name)]
        public static extern void igSetScrollY(float scroll_y);
        [DllImport(dll_name)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport(dll_name)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport(dll_name)]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport(dll_name)]
        public static extern void igSetWindowCollapsedBool(byte collapsed, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetWindowCollapsedStr(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetWindowFocus();
        [DllImport(dll_name)]
        public static extern void igSetWindowFocusStr(byte* name);
        [DllImport(dll_name)]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport(dll_name)]
        public static extern void igSetWindowPosVec2(Vector2 pos, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetWindowPosStr(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetWindowSizeVec2(Vector2 size, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igSetWindowSizeStr(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport(dll_name)]
        public static extern void igShowAboutWindow(byte* p_open);
        [DllImport(dll_name)]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport(dll_name)]
        public static extern void igShowFontSelector(byte* label);
        [DllImport(dll_name)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport(dll_name)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport(dll_name)]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport(dll_name)]
        public static extern void igShowUserGuide();
        [DllImport(dll_name)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSliderFloat2(byte* label, Vector2* v, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSliderFloat3(byte* label, Vector3* v, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSliderFloat4(byte* label, Vector4* v, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igSmallButton(byte* label);
        [DllImport(dll_name)]
        public static extern void igSpacing();
        [DllImport(dll_name)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport(dll_name)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport(dll_name)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport(dll_name)]
        public static extern void igText(byte* fmt);
        [DllImport(dll_name)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport(dll_name)]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport(dll_name)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport(dll_name)]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igTreeNodeStr(byte* label);
        [DllImport(dll_name)]
        public static extern byte igTreeNodeStrStr(byte* str_id, byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igTreeNodePtr(void* ptr_id, byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igTreeNodeExStr(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport(dll_name)]
        public static extern byte igTreeNodeExStrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(dll_name)]
        public static extern byte igTreeNodeExPtr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport(dll_name)]
        public static extern void igTreePop();
        [DllImport(dll_name)]
        public static extern void igTreePushStr(byte* str_id);
        [DllImport(dll_name)]
        public static extern void igTreePushPtr(void* ptr_id);
        [DllImport(dll_name)]
        public static extern void igUnindent(float indent_w);
        [DllImport(dll_name)]
        public static extern void igValueBool(byte* prefix, byte b);
        [DllImport(dll_name)]
        public static extern void igValueInt(byte* prefix, int v);
        [DllImport(dll_name)]
        public static extern void igValueUint(byte* prefix, uint v);
        [DllImport(dll_name)]
        public static extern void igValueFloat(byte* prefix, float v, byte* float_format);
        [DllImport(dll_name)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format);
        [DllImport(dll_name)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, float power);
        [DllImport(dll_name)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImColor_HSV_nonUDT2")]
        public static extern ImColor ImColor_HSV(ImColor* self, float h, float s, float v, float a);
        [DllImport(dll_name)]
        public static extern ImColor* ImColor_ImColor();
        [DllImport(dll_name)]
        public static extern ImColor* ImColor_ImColorInt(int r, int g, int b, int a);
        [DllImport(dll_name)]
        public static extern ImColor* ImColor_ImColorU32(uint rgba);
        [DllImport(dll_name)]
        public static extern ImColor* ImColor_ImColorFloat(float r, float g, float b, float a);
        [DllImport(dll_name)]
        public static extern ImColor* ImColor_ImColorVec4(Vector4 col);
        [DllImport(dll_name)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport(dll_name)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport(dll_name)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport(dll_name)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport(dll_name)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport(dll_name)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport(dll_name)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport(dll_name)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddBezierCurve(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, byte closed, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddText(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddTextFontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport(dll_name)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport(dll_name)]
        public static extern void ImDrawList_Clear(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_ClearFreeMemory(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMax_nonUDT2")]
        public static extern Vector2 ImDrawList_GetClipRectMax(ImDrawList* self);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImDrawList_GetClipRectMin_nonUDT2")]
        public static extern Vector2 ImDrawList_GetClipRectMin(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathBezierCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawCornerFlags rounding_corners);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, byte closed, float thickness);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport(dll_name)]
        public static extern void ImDrawList_UpdateClipRect(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawList_UpdateTextureID(ImDrawList* self);
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport(dll_name)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport(dll_name)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport(dll_name)]
        public static extern void ImFont_AddGlyph(ImFont* self, ushort c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport(dll_name)]
        public static extern void ImFont_AddRemapChar(ImFont* self, ushort dst, ushort src, byte overwrite_dst);
        [DllImport(dll_name)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport(dll_name, CallingConvention = CallingConvention.Cdecl, EntryPoint = "ImFont_CalcTextSizeA_nonUDT2")]
        public static extern Vector2 ImFont_CalcTextSizeA(ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport(dll_name)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport(dll_name)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport(dll_name)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport(dll_name)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, ushort c);
        [DllImport(dll_name)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, ushort c);
        [DllImport(dll_name)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, ushort c);
        [DllImport(dll_name)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport(dll_name)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport(dll_name)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport(dll_name)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport(dll_name)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, ushort c);
        [DllImport(dll_name)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport(dll_name)]
        public static extern void ImFont_SetFallbackChar(ImFont* self, ushort c);
        [DllImport(dll_name)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, ushort id, int width, int height, float advance_x, Vector2 offset);
        [DllImport(dll_name)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, uint id, int width, int height);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(dll_name)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, ushort* glyph_ranges);
        [DllImport(dll_name)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern ushort* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport(dll_name)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport(dll_name)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport(dll_name)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport(dll_name)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport(dll_name)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport(dll_name)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport(dll_name)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport(dll_name)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, ushort c);
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, ushort* ranges);
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport(dll_name)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport(dll_name)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport(dll_name)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, int n);
        [DllImport(dll_name)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport(dll_name)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport(dll_name)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport(dll_name)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport(dll_name)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport(dll_name)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport(dll_name)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport(dll_name)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport(dll_name)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport(dll_name)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport(dll_name)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport(dll_name)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport(dll_name)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper(int items_count, float items_height);
        [DllImport(dll_name)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport(dll_name)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport(dll_name)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport(dll_name)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport(dll_name)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport(dll_name)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport(dll_name)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport(dll_name)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(dll_name)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport(dll_name)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport(dll_name)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport(dll_name)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport(dll_name)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport(dll_name)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport(dll_name)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport(dll_name)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport(dll_name)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport(dll_name)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairInt(uint _key, int _val_i);
        [DllImport(dll_name)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairFloat(uint _key, float _val_f);
        [DllImport(dll_name)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePairPtr(uint _key, void* _val_p);
        [DllImport(dll_name)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport(dll_name)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport(dll_name)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport(dll_name)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport(dll_name)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport(dll_name)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport(dll_name)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport(dll_name)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport(dll_name)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport(dll_name)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport(dll_name)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport(dll_name)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport(dll_name)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport(dll_name)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport(dll_name)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport(dll_name)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange();
        [DllImport(dll_name)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRangeStr(byte* _b, byte* _e);
        [DllImport(dll_name)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport(dll_name)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport(dll_name)]
        public static extern Vector2* ImVec2_ImVec2();
        [DllImport(dll_name)]
        public static extern Vector2* ImVec2_ImVec2Float(float _x, float _y);
        [DllImport(dll_name)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport(dll_name)]
        public static extern Vector4* ImVec4_ImVec4();
        [DllImport(dll_name)]
        public static extern Vector4* ImVec4_ImVec4Float(float _x, float _y, float _z, float _w);
    }
}
