# GTA-V-menu
.Net Framework용 GTA V 메뉴 디자인

## Preview

![데모](https://user-images.githubusercontent.com/34199905/138864815-7d880c95-a1a2-4e88-b7c6-945a5a2f0c93.png)

데모

- GTA V 메뉴 디자인
- 키보드 입력 지원
- 단순한 인터페이스
- 분리가능한 컨트롤

## Download

데모 프로그램 - [here]()

GTAVUI 라이브러리 - [here]()

## Examples

1. 메뉴 폼 만들기

   ```csharp
   var GTAVUIForm = new VListViewForm();
   // 위치 오른쪽 위로 지정
   GTAVUIForm.Location = new Point(screens.WorkingArea.Location.X + 12, screens.WorkingArea.Location.Y + 12);
   GTAVUIForm.Show();
   ```

2. 아이템 추가하기

   ```csharp
   GTAVUIForm.View.Add(new VListViewItem("Text"));
   ```

   ```csharp
   new VListViewItem(
       // 텍스트
       "Text",
       // 활성화 여부
       false,
       // 폴더 모드
       false,
       // 라벨 모드
       false,
       // 선택됨 (분리 컨트롤에서만)
       false,
       // 설명 사용 여부
       true,
       // 설명 텍스트
       "Hello world!",
       // 설명 텍스트 줄 갯수
       1,
       // object tag
       null
   )
   ```

3. 뷰 세로 길이

   ```csharp
   GTAVUIForm.View.HSize = 4;
   ```

이 외의 기능은 Windows Form의 기능입니다.



## 컨트롤 분리

![image](https://user-images.githubusercontent.com/34199905/138869543-64008bef-84b0-4a84-86d7-b38c99e9c4dc.png)
