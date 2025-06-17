
# GDombo_CustomControl

.NET Framework 4.8 기반으로 제작된 WinForms 전용 사용자 정의 컨트롤 모음입니다.  
Visual Studio 2022에서 개발되었으며, 보다 직관적이고 성능 좋은 UI 컴포넌트를 제공합니다.

---

## 📦 프로젝트 개요

이 프로젝트는 C# WinForms에서 기본 컨트롤의 기능을 확장한 다음과 같은 커스텀 컨트롤을 제공합니다:

- **CheckBoxComboBox**  
  다중 선택이 가능한 콤보박스. 각 항목은 체크박스로 표시되며 선택 상태를 텍스트에 반영합니다.

- **ColorComboBox**  
  ColorDialog 없이도 미리 정의된 색상 중 하나를 선택할 수 있는 컬러 콤보박스입니다. 드롭다운에서 색상 블록을 바로 선택 가능.

- **DoubleBufferedDataGridView**  
  깜빡임 없는 부드러운 렌더링을 위한 더블 버퍼링이 적용된 DataGridView입니다.

---

## 🧰 기술 스택

- **Framework**: .NET Framework 4.8  
- **IDE**: Visual Studio 2022  
- **언어**: C# (.NET Windows Forms)  

---

## 🏗️ 설치 및 사용법

1. Visual Studio 2022에서 `GDombo_CustomControl.sln` 솔루션 열기
2. 솔루션 빌드 (`Ctrl + Shift + B`)
3. 빌드된 DLL을 다른 WinForms 프로젝트에서 참조하거나,
4. 소스 코드를 직접 복사하여 커스터마이징해 사용

---

## 📌 주의사항

- 본 프로젝트는 컨트롤 라이브러리 형태로 동작하며, 실행 가능한 데모 애플리케이션은 포함되어 있지 않습니다.
- 각 컨트롤은 디자인 모드에서도 사용 가능하며, ToolBox에 수동 등록하여 시각적으로 구성할 수 있습니다.

---

## 📂 구조

```
GDombo_CustomControl/
├── GDombo_CustomControl.sln
├── GDombo_CustomControl/
│   ├── CheckBoxComboBox.cs
│   ├── ColorComboBox.cs
│   ├── DoubleBufferedDataGridView.cs
│   └── ...
```

---

<br><br>

---

# GDombo_CustomControl (English)

A custom WinForms control library for .NET Framework 4.8.  
This project provides extended and reusable components for Windows Forms development, written in C# and built with Visual Studio 2022.

---

## 🧩 Included Controls

- **CheckBoxComboBox**  
  A combo box allowing multiple selections with checkbox UI for each item. Selected values are displayed in the textbox.

- **ColorComboBox**  
  A dropdown combo box with selectable color swatches, letting users pick a predefined color without a separate color dialog.

- **DoubleBufferedDataGridView**  
  A flicker-free DataGridView that enables smoother rendering using double buffering.

---

## 🛠️ Tech Stack

- **Framework**: .NET Framework 4.8  
- **IDE**: Visual Studio 2022  
- **Language**: C# (WinForms)

---

## 🧪 How to Use

1. Open the solution file `GDombo_CustomControl.sln` in Visual Studio 2022
2. Build the solution (`Ctrl + Shift + B`)
3. Add the built DLL to your project references  
   or copy the control source files directly into your project

---

## ⚠️ Notes

- This project is a control library and does not include a demo executable.
- Controls can be added to the Visual Studio Toolbox for drag-and-drop usage in the designer.

---

## 📁 Structure

```
GDombo_CustomControl/
├── GDombo_CustomControl.sln
├── GDombo_CustomControl/
│   ├── CheckBoxComboBox.cs
│   ├── ColorComboBox.cs
│   ├── DoubleBufferedDataGridView.cs
│   └── ...
```

---
