import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HspaysComponent } from './hspays.component';

describe('HspaysComponent', () => {
  let component: HspaysComponent;
  let fixture: ComponentFixture<HspaysComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HspaysComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HspaysComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
