import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LformsComponent } from './lforms.component';

describe('LformsComponent', () => {
  let component: LformsComponent;
  let fixture: ComponentFixture<LformsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LformsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LformsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
