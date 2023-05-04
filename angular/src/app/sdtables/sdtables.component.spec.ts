import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SdtablesComponent } from './sdtables.component';

describe('SdtablesComponent', () => {
  let component: SdtablesComponent;
  let fixture: ComponentFixture<SdtablesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SdtablesComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SdtablesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
