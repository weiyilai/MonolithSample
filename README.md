# Monolith Sample
![](https://camo.laiweiyi.com/18e41cd4111ff9a48173aa2ecc21ae429d98105f/68747470733a2f2f6c6561726e2e6d6963726f736f66742e636f6d2f7a682d74772f646f746e65742f6172636869746563747572652f6d6f6465726e2d7765622d617070732d617a7572652f6d656469612f696d616765352d312e706e67)
單體式專案，關注點分離是透過資料夾的使用而達成

預設範本包含 Models、Views 和 Controllers 等 MVC 模式責任的個別資料夾

以及用於資料(Data)和服務(Services)的其他資料夾

這種方式中，盡量將展示層限制在 Views 資料夾

資料存取實作限制在 Data 資料夾中

商業邏輯位於 Services 資料夾內的類別 Application Services (interfaces and implementations)

## 缺點
隨著業務場景擴大、複雜度增加，檔案和資料夾也會持續成長

使用者介面 (UI) 考量 (模型、檢視、控制器) 位於不依字母順序分組在一起的多個資料夾中

當有其他 UI 層級建構，例如 Filter 或 ModelBinder ，新增到它們自己的資料夾中時，此問題只會惡化

商業邏輯散佈在 Models 和 Services 資料夾之間，且不會清楚指出哪些資料夾中的哪些類別應該相依於哪些其他類別

這種在專案分層缺乏的情形經常會導致 [Spaghetti Code](https://deviq.com/antipatterns/spaghetti-code)

參考來源 [All-in-one applications](https://learn.microsoft.com/zh-tw/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#all-in-one-applications)
