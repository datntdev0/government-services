import { registerLocaleData } from '@angular/common';
import en from "@angular/common/locales/en";
import enExtra from "@angular/common/locales/extra/en";
import vi from "@angular/common/locales/vi";
import viExtra from "@angular/common/locales/extra/vi";

const localeModuleLoader = {
  'en': function () { registerLocaleData([...en, ...enExtra]); },
  'vi': function () { registerLocaleData([...vi, ...viExtra]); },
};

export default localeModuleLoader;
